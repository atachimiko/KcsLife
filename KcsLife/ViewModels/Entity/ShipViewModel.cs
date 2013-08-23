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
using KcsLife.Models.Api;

namespace KcsLife.ViewModels.Entity
{
	public class ShipViewModel : ViewModel
	{

		//=====================================================================
		#region 公開メソッド
		//=====================================================================

		#endregion

		//=====================================================================
		#region コンストラクタ・デストラクタ・Dispose
		//=====================================================================
		public ShipViewModel(ShipData entity,MainWindowViewModel workspace)
		{
			this.Workspace = new WeakReference<MainWindowViewModel>(workspace);
			this.Entity = entity;
		}

		#endregion

		//=====================================================================
		#region プロパティ
		//=====================================================================
		#region Entity変更通知プロパティ
		private ShipData _Entity;

		public ShipData Entity
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


		#region ShipNameプロパティ
		/// <summary>
		/// 艦船名を取得します
		/// </summary>
		public string ShipName
		{
			get
			{
				MainWindowViewModel workspace;
				if (this.Workspace.TryGetTarget(out workspace))
				{
					if (workspace.ShipTable.ContainsKey(this.Entity.Sortno))
					{
						return workspace.ShipTable[this.Entity.Sortno];
					}
				}
				return "";
			}
		}
		#endregion

		#region RateHpプロパティ
		public string RateHp
		{
			get
			{
				var a = ((float)this.Entity.NowHp / (float)this.Entity.MaxHp) * 100.0;
				return string.Format("{0:0.#} %",a);
			}
		}
		#endregion

		#region HpTextプロパティ
		public string HpText
		{
			get
			{
				return string.Format("{0} / {1} ({2})", this.Entity.NowHp, this.Entity.MaxHp, RateHp);
			}
		}
		#endregion

		#endregion


		//=====================================================================
		#region フィールド
		//=====================================================================
		WeakReference<MainWindowViewModel> Workspace;
		#endregion

	}
}
