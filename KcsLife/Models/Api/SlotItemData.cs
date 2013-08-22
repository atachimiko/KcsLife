using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	public class SlotItemData: ModelBase
	{
		#region Data変更通知プロパティ
		private List<MyData> _Data;
		[JsonProperty(PropertyName = "api_data")]
		public List<MyData> Data
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

		public class MyData : ApiDataItemBase
		{

			#region SlotitemId変更通知プロパティ
			private int _SlotitemId;
			[JsonProperty(PropertyName = "api_slotitem_id")]
			public int SlotitemId
			{
				get
				{ return _SlotitemId; }
				set
				{ 
					if (_SlotitemId == value)
						return;
					_SlotitemId = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Type変更通知プロパティ
			private List<int> _Type;
			[JsonProperty(PropertyName = "api_type")]
			public List<int> Type
			{
				get
				{ return _Type; }
				set
				{ 
					if (_Type == value)
						return;
					_Type = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Taik変更通知プロパティ
			private int _Taik;
			[JsonProperty(PropertyName = "api_taik")]
			public int Taik
			{
				get
				{ return _Taik; }
				set
				{ 
					if (_Taik == value)
						return;
					_Taik = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Souk変更通知プロパティ
			private int _Souk;
			[JsonProperty(PropertyName = "api_souk")]
			public int Souk
			{
				get
				{ return _Souk; }
				set
				{ 
					if (_Souk == value)
						return;
					_Souk = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Houg変更通知プロパティ
			private int _Houg;
			[JsonProperty(PropertyName = "api_houg")]
			public int Houg
			{
				get
				{ return _Houg; }
				set
				{ 
					if (_Houg == value)
						return;
					_Houg = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Raig変更通知プロパティ
			private int _Raig;
			[JsonProperty(PropertyName = "api_raig")]
			public int Raig
			{
				get
				{ return _Raig; }
				set
				{ 
					if (_Raig == value)
						return;
					_Raig = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Raim変更通知プロパティ
			private int _Raim;
			[JsonProperty(PropertyName = "api_raim")]
			public int Raim
			{
				get
				{ return _Raim; }
				set
				{ 
					if (_Raim == value)
						return;
					_Raim = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Kaih変更通知プロパティ
			private int _Kaih;

			public int Kaih
			{
				get
				{ return _Kaih; }
				set
				{ 
					if (_Kaih == value)
						return;
					_Kaih = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Houk変更通知プロパティ
			private int _Houk;
			[JsonProperty(PropertyName = "api_houk")]
			public int Houk
			{
				get
				{ return _Houk; }
				set
				{ 
					if (_Houk == value)
						return;
					_Houk = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Raik変更通知プロパティ
			private int _Raik;
			[JsonProperty(PropertyName = "api_raik")]
			public int Raik
			{
				get
				{ return _Raik; }
				set
				{ 
					if (_Raik == value)
						return;
					_Raik = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Bakk変更通知プロパティ
			private int _Bakk;
			[JsonProperty(PropertyName = "api_bakk")]
			public int Bakk
			{
				get
				{ return _Bakk; }
				set
				{ 
					if (_Bakk == value)
						return;
					_Bakk = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Saku変更通知プロパティ
			private int _Saku;
			[JsonProperty(PropertyName = "api_saku")]
			public int Saku
			{
				get
				{ return _Saku; }
				set
				{ 
					if (_Saku == value)
						return;
					_Saku = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Sakb変更通知プロパティ
			private int _Sakb;
			[JsonProperty(PropertyName = "api_sakb")]
			public int Sakb
			{
				get
				{ return _Sakb; }
				set
				{ 
					if (_Sakb == value)
						return;
					_Sakb = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Luck変更通知プロパティ
			private int _Luck;
			[JsonProperty(PropertyName = "api_luck")]
			public int Luck
			{
				get
				{ return _Luck; }
				set
				{ 
					if (_Luck == value)
						return;
					_Luck = value;
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


			#region Rare変更通知プロパティ
			private int _Rare;
			[JsonProperty(PropertyName = "api_rare")]
			public int Rare
			{
				get
				{ return _Rare; }
				set
				{ 
					if (_Rare == value)
						return;
					_Rare = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Broken変更通知プロパティ
			private List<int> _Broken;
			[JsonProperty(PropertyName = "api_broken")]
			public List<int> Broken
			{
				get
				{ return _Broken; }
				set
				{ 
					if (_Broken == value)
						return;
					_Broken = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Info変更通知プロパティ
			private string _Info;
			[JsonProperty(PropertyName = "api_info")]
			public string Info
			{
				get
				{ return _Info; }
				set
				{ 
					if (_Info == value)
						return;
					_Info = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Flag変更通知プロパティ
			private List<string> _Flag;
			[JsonProperty(PropertyName = "api_flag")]
			public List<string> Flag
			{
				get
				{ return _Flag; }
				set
				{ 
					if (_Flag == value)
						return;
					_Flag = value;
					RaisePropertyChanged();
				}
			}
			#endregion

		}
	}
}
