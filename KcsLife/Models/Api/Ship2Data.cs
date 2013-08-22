using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	public class Ship2Data : ModelBase
	{
		#region Data変更通知プロパティ
		private List<ShipData> _Data;
		[JsonProperty(PropertyName = "api_data")]
		public List<ShipData> Data
		{
			get
			{ return _Data; }
			set
			{
				if (_Data == value)
					return;
				_Data = value;
				RaisePropertyChanged();
			}
		}
		#endregion
	}

	public class ShipData : ApiDataItemBase
	{
		// api_idは所有艦テーブルのID

		#region Sortno変更通知プロパティ
		private int _Sortno;
		/// <summary>
		/// 艦情報テーブルのID
		/// </summary>
		[JsonProperty(PropertyName = "api_sortno")]
		public int Sortno
		{
			get
			{ return _Sortno; }
			set
			{
				if (_Sortno == value)
					return;
				_Sortno = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region ShipId変更通知プロパティ
		private int _ShipId;
		[JsonProperty(PropertyName = "api_ship_id")]
		public int ShipId
		{
			get
			{ return _ShipId; }
			set
			{
				if (_ShipId == value)
					return;
				_ShipId = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Lv変更通知プロパティ
		private int _Lv;
		[JsonProperty(PropertyName = "api_lv")]
		public int Lv
		{
			get
			{ return _Lv; }
			set
			{
				if (_Lv == value)
					return;
				_Lv = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Exp変更通知プロパティ
		private int _Exp;
		[JsonProperty(PropertyName = "api_exp")]
		public int Exp
		{
			get
			{ return _Exp; }
			set
			{
				if (_Exp == value)
					return;
				_Exp = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region NowHp変更通知プロパティ
		private int _NowHp;
		[JsonProperty(PropertyName = "api_nowhp")]
		public int NowHp
		{
			get
			{ return _NowHp; }
			set
			{
				if (_NowHp == value)
					return;
				_NowHp = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region MaxHp変更通知プロパティ
		private int _MaxHp;
		[JsonProperty(PropertyName = "api_maxhp")]
		public int MaxHp
		{
			get
			{ return _MaxHp; }
			set
			{
				if (_MaxHp == value)
					return;
				_MaxHp = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Leng変更通知プロパティ
		private int _Leng;
		[JsonProperty(PropertyName = "api_leng")]
		public int Leng
		{
			get
			{ return _Leng; }
			set
			{
				if (_Leng == value)
					return;
				_Leng = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Slot変更通知プロパティ
		private List<int> _Slot;
		[JsonProperty(PropertyName = "api_slot")]
		public List<int> Slot
		{
			get
			{ return _Slot; }
			set
			{
				if (_Slot == value)
					return;
				_Slot = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Onslot変更通知プロパティ
		private List<int> _Onslot;
		[JsonProperty(PropertyName = "api_onslot")]
		public List<int> Onslot
		{
			get
			{ return _Onslot; }
			set
			{
				if (_Onslot == value)
					return;
				_Onslot = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Kyouka変更通知プロパティ
		private List<int> _Kyouka;
		[JsonProperty(PropertyName = "api_kyouka")]
		public List<int> Kyouka
		{
			get
			{ return _Kyouka; }
			set
			{
				if (_Kyouka == value)
					return;
				_Kyouka = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Backs変更通知プロパティ
		private int _Backs;
		[JsonProperty(PropertyName = "api_backs")]
		public int Backs
		{
			get
			{ return _Backs; }
			set
			{
				if (_Backs == value)
					return;
				_Backs = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Fuel変更通知プロパティ
		private int _Fuel;
		[JsonProperty(PropertyName = "api_fuel")]
		public int Fuel
		{
			get
			{ return _Fuel; }
			set
			{
				if (_Fuel == value)
					return;
				_Fuel = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Bull変更通知プロパティ
		private int _Bull;
		[JsonProperty(PropertyName = "api_bull")]
		public int Bull
		{
			get
			{ return _Bull; }
			set
			{
				if (_Bull == value)
					return;
				_Bull = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Slotnum変更通知プロパティ
		private int _Slotnum;
		[JsonProperty(PropertyName = "api_slotnum")]
		public int Slotnum
		{
			get
			{ return _Slotnum; }
			set
			{
				if (_Slotnum == value)
					return;
				_Slotnum = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region NdockTime変更通知プロパティ
		private int _NdockTime;
		[JsonProperty(PropertyName = "api_ndock_time")]
		public int NdockTime
		{
			get
			{ return _NdockTime; }
			set
			{
				if (_NdockTime == value)
					return;
				_NdockTime = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region NdockItem変更通知プロパティ
		private List<int> _NdockItem;
		[JsonProperty(PropertyName = "api_nock_item")]
		public List<int> NdockItem
		{
			get
			{ return _NdockItem; }
			set
			{
				if (_NdockItem == value)
					return;
				_NdockItem = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Srate変更通知プロパティ
		private int _Srate;
		[JsonProperty(PropertyName = "api_srate")]
		public int Srate
		{
			get
			{ return _Srate; }
			set
			{
				if (_Srate == value)
					return;
				_Srate = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Cond変更通知プロパティ
		private int _Cond;
		[JsonProperty(PropertyName = "api_cond")]
		public int Cond
		{
			get
			{ return _Cond; }
			set
			{
				if (_Cond == value)
					return;
				_Cond = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Karyoku変更通知プロパティ
		private List<int> _Karyoku;
		[JsonProperty(PropertyName = "api_karyoku")]
		public List<int> Karyoku
		{
			get
			{ return _Karyoku; }
			set
			{
				if (_Karyoku == value)
					return;
				_Karyoku = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Raisou変更通知プロパティ
		private List<int> _Raisou;
		[JsonProperty(PropertyName = "api_raisou")]
		public List<int> Raisou
		{
			get
			{ return _Raisou; }
			set
			{
				if (_Raisou == value)
					return;
				_Raisou = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Taiku変更通知プロパティ
		private List<int> _Taiku;
		[JsonProperty(PropertyName = "api_taiku")]
		public List<int> Taiku
		{
			get
			{ return _Taiku; }
			set
			{
				if (_Taiku == value)
					return;
				_Taiku = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Soukou変更通知プロパティ
		private List<int> _Soukou;
		[JsonProperty(PropertyName = "api_soukou")]
		public List<int> Soukou
		{
			get
			{ return _Soukou; }
			set
			{
				if (_Soukou == value)
					return;
				_Soukou = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Kaihi変更通知プロパティ
		private List<int> _Kaihi;
		[JsonProperty(PropertyName = "api_kaihi")]
		public List<int> Kaihi
		{
			get
			{ return _Kaihi; }
			set
			{
				if (_Kaihi == value)
					return;
				_Kaihi = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Taisen変更通知プロパティ
		private List<int> _Taisen;
		[JsonProperty(PropertyName = "api_taisen")]
		public List<int> Taisen
		{
			get
			{ return _Taisen; }
			set
			{
				if (_Taisen == value)
					return;
				_Taisen = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Sakuteki変更通知プロパティ
		private List<int> _Sakuteki;
		[JsonProperty(PropertyName = "api_sakuteki")]
		public List<int> Sakuteki
		{
			get
			{ return _Sakuteki; }
			set
			{
				if (_Sakuteki == value)
					return;
				_Sakuteki = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Lucky変更通知プロパティ
		private List<int> _Lucky;
		[JsonProperty(PropertyName = "api_lucky")]
		public List<int> Lucky
		{
			get
			{ return _Lucky; }
			set
			{
				if (_Lucky == value)
					return;
				_Lucky = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Locked変更通知プロパティ
		private int _Locked;
		[JsonProperty(PropertyName = "api_locked")]
		public int Locked
		{
			get
			{ return _Locked; }
			set
			{
				if (_Locked == value)
					return;
				_Locked = value;
				RaisePropertyChanged();
			}
		}
		#endregion

	}
}
