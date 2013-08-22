using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	public class MapCellData: ModelBase
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

			#region MapNo変更通知プロパティ
			private int _MapNo;
			[JsonProperty(PropertyName = "api_map_no")]
			public int MapNo
			{
				get
				{ return _MapNo; }
				set
				{ 
					if (_MapNo == value)
						return;
					_MapNo = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region MapAreaId変更通知プロパティ
			private int _MapAreaId;
			[JsonProperty(PropertyName = "api_maparea_id")]
			public int MapAreaId
			{
				get
				{ return _MapAreaId; }
				set
				{ 
					if (_MapAreaId == value)
						return;
					_MapAreaId = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region MapInfoNo変更通知プロパティ
			private int _MapInfoNo;
			[JsonProperty(PropertyName = "api_mapinfo_no")]
			public int MapInfoNo
			{
				get
				{ return _MapInfoNo; }
				set
				{ 
					if (_MapInfoNo == value)
						return;
					_MapInfoNo = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region ColorNo変更通知プロパティ
			private int _ColorNo;
			[JsonProperty(PropertyName = "api_color_no")]
			public int ColorNo
			{
				get
				{ return _ColorNo; }
				set
				{ 
					if (_ColorNo == value)
						return;
					_ColorNo = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region LinkNo変更通知プロパティ
			private string _LinkNo;
			[JsonProperty(PropertyName = "api_link_no")]
			public string LinkNo
			{
				get
				{ return _LinkNo; }
				set
				{ 
					if (_LinkNo == value)
						return;
					_LinkNo = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Event変更通知プロパティ
			private List<int> _Event;
			[JsonProperty(PropertyName = "api_event")]
			public List<int> Event
			{
				get
				{ return _Event; }
				set
				{ 
					if (_Event == value)
						return;
					_Event = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region EventPoint変更通知プロパティ
			private List<int> _EventPoint;
			[JsonProperty(PropertyName = "api_event_point")]
			public List<int> EventPoint
			{
				get
				{ return _EventPoint; }
				set
				{ 
					if (_EventPoint == value)
						return;
					_EventPoint = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region TableNo変更通知プロパティ
			private List<int> _TableNo;
			[JsonProperty(PropertyName = "api_table_no")]
			public List<int> TableNo
			{
				get
				{ return _TableNo; }
				set
				{ 
					if (_TableNo == value)
						return;
					_TableNo = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region NextRate変更通知プロパティ
			private List<int> _NextRate;
			[JsonProperty(PropertyName = "api_next_rate")]
			public List<int> NextRate
			{
				get
				{ return _NextRate; }
				set
				{ 
					if (_NextRate == value)
						return;
					_NextRate = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region NextRateReq変更通知プロパティ
			private List<int> _NextRateReq;
			[JsonProperty(PropertyName = "api_next_rate_req")]
			public List<int> NextRateReq
			{
				get
				{ return _NextRateReq; }
				set
				{ 
					if (_NextRateReq == value)
						return;
					_NextRateReq = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region ReqShipCount変更通知プロパティ
			private int _ReqShipCount;
			[JsonProperty(PropertyName = "api_req_ship_count")]
			public int ReqShipCount
			{
				get
				{ return _ReqShipCount; }
				set
				{ 
					if (_ReqShipCount == value)
						return;
					_ReqShipCount = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region ReqShipType変更通知プロパティ
			private string _ReqShipType;
			[JsonProperty(PropertyName = "api_req_shiptype")]
			public string ReqShipType
			{
				get
				{ return _ReqShipType; }
				set
				{ 
					if (_ReqShipType == value)
						return;
					_ReqShipType = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Passed変更通知プロパティ
			private int _Passed;
			[JsonProperty(PropertyName = "api_passed")]
			public int Passed
			{
				get
				{ return _Passed; }
				set
				{ 
					if (_Passed == value)
						return;
					_Passed = value;
					RaisePropertyChanged();
				}
			}
			#endregion

		}
	}
}
