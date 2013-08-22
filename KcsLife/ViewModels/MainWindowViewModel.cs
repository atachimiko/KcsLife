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
			var result = await _Context.LoginCheck();
			Console.WriteLine(result.ResultMessage);
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
			this._Context = new KcsRequestContext(apipath, _ApplicationSettings.Token, _ApplicationSettings.Referer);
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

		#endregion

		//=====================================================================
		#region フィールド
		//=====================================================================
		readonly ObservableSynchronizedCollection<LogInfo> _LogInfo_Source = new ObservableSynchronizedCollection<LogInfo>();

		/// <summary>
		/// ユーザーが所有する艦船のコレクション
		/// </summary>
		/// <remarks>
		/// Rawデータ。
		/// サーバーからAPIを使って取得したデータそのままのもの。
		/// </remarks>
		readonly ObservableSynchronizedCollection<ShipData> _UserShip_Source = new ObservableSynchronizedCollection<ShipData>();

		readonly KcsRequestContext _Context;

		Dictionary<int, string> _ShipTable = new Dictionary<int, string>();

		ApplicationSettingsInfo _ApplicationSettings;
		#endregion


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

		}
	}
}
