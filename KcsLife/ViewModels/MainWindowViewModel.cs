using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Livet;
using Livet.Commands;
using Livet.Messaging;
using Livet.Messaging.IO;
using Livet.EventListeners;
using Livet.Messaging.Windows;

using KcsLife.Models;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using KcsLife.Models.Api;
using KcsLife.Gateways;
using KcsLife.Logic;
using KcsLife.ViewModels.Entity;
using System.IO;
using System.Timers;

namespace KcsLife.ViewModels
{
	public class MainWindowViewModel : ViewModel
	{

		//=====================================================================
		#region 公開メソッド
		//=====================================================================
		public void Initialize()
		{
		}

		/// <summary>
		/// 自動でミッションをこなす機能を開始する
		/// </summary>
		public async void StartAutoMissionRunner()
		{
			ReloadDock();
		}

		/// <summary>
		/// 出撃
		/// </summary>
		public async void DoButtleSequence()
		{
			var r = await _DoBattleSequence();
		}

		/// <summary>
		/// 
		/// </summary>
		public async void ChargeSequence()
		{
			List<ShipData> chargeShips = new List<ShipData>();
			foreach (var vm in this.Fleets[0].Ships)
			{
				var shipdata = vm.Entity;
				if (shipdata != null)
					chargeShips.Add(shipdata);
			}

			if (chargeShips.Count > 0)
			{
				var r_charge = await _Context.LoadCharge(chargeShips);
				if (r_charge.Result != 1) return;

				var result_b = await LoadShip2Async();
			}

			AddLog("補給", "補給しました");
		}

		/// <summary>
		/// ドックでの情報を取得する
		/// </summary>
		public async void ReloadDock()
		{
			var r_actionlog = await _Context.LoadActionLog();
			if (r_actionlog.Result != 1) return;

			var r_logincheck = await _Context.LoadLoginCheck();
			if (r_actionlog.Result != 1) return;

			var r_material = await _Context.LoadMaterial();
			if (r_material.Result != 1) return;

			var r_deck_port = await _Context.LoadDeckPort();
			if (r_deck_port.Result != 1) return;

			var r_ndock = await _Context.LoadNDock();
			if (r_ndock.Result != 1) return;

			var result_b = await LoadShip2Async();
			var r_basic = await _Context.LoadBasic();
			if (r_basic.Result != 1) return;
			
			//
			// 艦隊の設定
			foreach (var deck in r_deck_port.Data)
			{
				var fleet = this._Fleets[deck.Id - 1];
				fleet.Ships.Clear();
				fleet.MissionText = string.Join("_", deck.Mission);
				foreach (var dsi in deck.Ship)
				{
					if (dsi != -1)
						fleet.Ships.Add(FindShip(dsi));
				}
			}
		}

		public void BeginSequence()
		{
			if (this.AbTimer.Enabled)
			{
				AddLog("情報", "モードAを解除しました。");
				this.AbTimer.Enabled = false;
				this.AbTimer.Stop();
			}
			else
			{
				AddLog("情報", "モードAを開始しました。");
				this.AbTimer.Enabled = true;
				this.AbTimer.Start();
			}
		}
		
		#endregion
		

		//=====================================================================
		#region コンストラクタ・デストラクタ・Dispose
		//=====================================================================
		public MainWindowViewModel()
		{
			_LogInfos = ViewModelHelper.CreateReadOnlyDispatcherCollection<LogInfo, __LogInfoViewModel>(_LogInfo_Source, (p) => new __LogInfoViewModel(p), DispatcherHelper.UIDispatcher);
			_Ships = ViewModelHelper.CreateReadOnlyDispatcherCollection<ShipData, ShipViewModel>(this._UserShip_Source, (p) => new ShipViewModel(p, this), DispatcherHelper.UIDispatcher);


			_LogInfo_Source.Add(new LogInfo
			{
				LogDate = DateTime.Now,
				InfoType = "情報",
				Message = "アプリケーションを開始しました。"
			});


			LoadApplicationSettingFile();


			Dictionary<string, string> apipath;

			{
				var inst = new ShipCsvLoader();
				this._ShipTable = inst.Load();
			}
			{
				var inst = new ApiPathCsvLoader();
				apipath = inst.Load();
			}


			this._Context = new KcsRequestContext(apipath, _ApplicationSettings.BaseUrl, _ApplicationSettings.Referer);
			this._Context.Token =_ApplicationSettings.Token;

			this.AbTimer = new Timer();
			this.AbTimer.Interval = 60000 * 1;
			this.AbTimer.Elapsed += AbTimer_Elapsed;
		}

		void AbTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
			lock (this)
			{
				if (this.AbTimerOverroadFlag) return;

				this.AbTimerOverroadFlag = true;
			}

			AddLog("情報", "戦闘を開始します");

			var r = _DoBattleSequence();
			r.ContinueWith((task) =>
			{
				ChargeSequence();

				lock (this)
				{
					this.AbTimerOverroadFlag = false;
				}
			});

			
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}
		#endregion

		//=====================================================================
		#region プロパティ
		//=====================================================================
		#region LogInfosプロパティ
		readonly ReadOnlyDispatcherCollection<__LogInfoViewModel> _LogInfos;
		public ReadOnlyDispatcherCollection<__LogInfoViewModel> LogInfos { get { return _LogInfos; } }
		#endregion

		#region Shipsプロパティ
		readonly ReadOnlyDispatcherCollection<ShipViewModel> _Ships;
		public ReadOnlyDispatcherCollection<ShipViewModel> Ships { get { return _Ships; } }
		#endregion

		#region ShipTableプロパティ
		public Dictionary<int, string> ShipTable
		{
			get { return _ShipTable; }
		}
		#endregion

		#region Fleetsプロパティ
		public ObservableSynchronizedCollection<__FleetViewModel> Fleets
		{
			get { return _Fleets; }
		}
		#endregion
		#endregion

		//=====================================================================
		#region フィールド
		//=====================================================================
		/// <summary>
		/// 
		/// </summary>
		bool AbTimerOverroadFlag = false;

		/// <summary>
		/// 
		/// </summary>
		Timer AbTimer;

		/// <summary>
		/// 
		/// </summary>
		readonly ObservableSynchronizedCollection<LogInfo> _LogInfo_Source = new ObservableSynchronizedCollection<LogInfo>();

		/// <summary>
		/// ユーザーが所有する艦船のコレクション
		/// </summary>
		/// <remarks>
		/// Rawデータ。
		/// サーバーからAPIを使って取得したデータそのままのもの。
		/// </remarks>
		readonly ObservableSynchronizedCollection<ShipData> _UserShip_Source = new ObservableSynchronizedCollection<ShipData>();

		/// <summary>
		/// 艦隊一覧
		/// </summary>
		readonly ObservableSynchronizedCollection<__FleetViewModel> _Fleets = new ObservableSynchronizedCollection<__FleetViewModel>(
			new __FleetViewModel[] { new __FleetViewModel(), new __FleetViewModel(), new __FleetViewModel(), new __FleetViewModel() }
		);

		/// <summary>
		/// 
		/// </summary>
		readonly KcsRequestContext _Context;

		Dictionary<int, string> _ShipTable = new Dictionary<int, string>();

		ApplicationSettingsInfo _ApplicationSettings;
		#endregion


		/// <summary>
		/// ship2を呼び出して得た艦船データを格納する
		/// </summary>
		private async Task<bool> LoadShip2Async()
		{
			var result = await _Context.LoadShip2();
			if (result != null && result.Result == 1)
			{
				foreach (var prop in result.Data)
				{
					var r = from u in _UserShip_Source
							where u.Id == prop.Id
							select u;

					// 値のみのコピーは面倒なので、インスタンス毎置き換える
					if (r.FirstOrDefault() != null)
					{
						var a = r.FirstOrDefault();
						_UserShip_Source.Remove(a);
					}

					_UserShip_Source.Add(prop);
				}
				return true;
			}
			else
			{
				Console.WriteLine("エラー");
				return false;
			}
		}

		async Task<bool> _DoBattleSequence()
		{
			var r_record = await _Context.LoadRecord();
			if (r_record.Result != 1) return false;

			var r_mapinfo = await _Context.LoadMapInfo();
			if (r_mapinfo.Result != 1) return false;

			var r_mapcell = await _Context.LoadMapCell(1, 1);
			if (r_mapcell.Result != 1) return false;

			var r_start = await _Context.LoadStart(1, 1, 1, 1);
			if (r_start.Result != 1) return false;

			await Task.Delay(5000);

			var r_battle = await _Context.LoadBattle(1);
			if (r_battle.Result != 1) return false;

			await Task.Delay(10000);

			var r_battleresult = await _Context.LoadBattleResult();
			if (r_battleresult.Result != 1) return false;
			
			AddLog("出撃", "戦闘結果ランク=" + r_battleresult.Data.WinRank);
			await Task.Delay(5000);

			var r_slotitem = await _Context.LoadSlotItem();
			if (r_slotitem.Result != 1) return false;

			var r_deck = await _Context.LoadDeck();
			if (r_deck.Result != 1) return false;

			return true;
		}

		/// <summary>
		/// アプリケーション設定ファイルから設定情報を読み込む
		/// </summary>
		private void LoadApplicationSettingFile()
		{
			var path = "kcs_settings.conf";

			if (_ApplicationSettings == null)
				_ApplicationSettings = new ApplicationSettingsInfo();

			if (File.Exists(path))
			{
				using (var sr = new StreamReader(path, Encoding.GetEncoding("utf-8")))
				{
					_ApplicationSettings.Load(sr);
				}
			}
			else
			{
				using (var sr = new StreamWriter(path))
				{
					_ApplicationSettings.Save(sr);
				}
				throw new ApplicationException("アプリケーション設定ファイルを作成しました");
			}
		}

		/// <summary>
		/// デッキ内から艦船データを取得します
		/// </summary>
		/// <param name="id"></param>
		/// <returns>艦船データ。見つからない場合はNull。</returns>
		ShipViewModel FindShip(long id)
		{
			var r = from u in this.Ships
					where u.Entity.Id == id
					select u;
			return r.FirstOrDefault();
		}

		/// <summary>
		/// ログ出力欄に表示するテキストを追加します
		/// </summary>
		/// <param name="caption"></param>
		/// <param name="message"></param>
		void AddLog(string caption, string message)
		{
			_LogInfo_Source.Insert(0,
				new LogInfo
			{
				LogDate = DateTime.Now,
				InfoType = caption,
				Message = message
			});
		}

		public class __LogInfoViewModel : ViewModel
		{
			public __LogInfoViewModel(LogInfo entity)
			{
				this.Entity = entity;
			}


			#region Entity変更通知プロパティ
			private LogInfo _Entity;

			public LogInfo Entity
			{
				get
				{ return _Entity; }
				private set
				{ 
					if (_Entity == value)
						return;
					_Entity = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region LogDateTextプロパティ

			public string LogDateText
			{
				get
				{
					return this.Entity.LogDate.ToString("F");
				}
			}
			#endregion

		}

		/// <summary>
		/// 艦隊情報
		/// </summary>
		public class __FleetViewModel : ViewModel
		{

			#region MissionText変更通知プロパティ
			private string _MissionText;

			public string MissionText
			{
				get
				{ return _MissionText; }
				set
				{ 
					if (_MissionText == value)
						return;
					_MissionText = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			/// <summary>
			/// 艦隊に所属する艦船のコレクションです
			/// </summary>
			/// <remarks>
			/// 新たに艦船を追加する場合や艦隊から艦船を削除する場合には、
			/// このコレクションを直接操作してください。
			/// </remarks>
			public ObservableSynchronizedCollection<ShipViewModel> Ships { get { return _Ships; } }

			
			readonly ObservableSynchronizedCollection<ShipViewModel> _Ships = new ObservableSynchronizedCollection<ShipViewModel>();
		}
	}
}
