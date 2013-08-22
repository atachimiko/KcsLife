using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	public class ResultData: ModelBase
	{
		#region Data変更通知プロパティ
		private MyData _Data;
		[JsonProperty(PropertyName = "api_data")]
		public MyData Data
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

			#region ShipId変更通知プロパティ
			private List<int> _ShipId;
			[JsonProperty(PropertyName = "api_ship_id")]
			public List<int> ShipId
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


			#region Result変更通知プロパティ
			private int _Result;
			[JsonProperty(PropertyName = "api_result")]
			public int Result
			{
				get
				{ return _Result; }
				set
				{ 
					if (_Result == value)
						return;
					_Result = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region GetExp変更通知プロパティ
			private int _GetExp;
			[JsonProperty(PropertyName = "api_get_exp")]
			public int GetExp
			{
				get
				{ return _GetExp; }
				set
				{ 
					if (_GetExp == value)
						return;
					_GetExp = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region MemberLv変更通知プロパティ
			private int _MemberLv;
			[JsonProperty(PropertyName = "api_member_lv")]
			public int MemberLv
			{
				get
				{ return _MemberLv; }
				set
				{ 
					if (_MemberLv == value)
						return;
					_MemberLv = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region MemberExp変更通知プロパティ
			private int _MemberExp;
			[JsonProperty(PropertyName = "api_member_exp")]
			public int MemberExp
			{
				get
				{ return _MemberExp; }
				set
				{ 
					if (_MemberExp == value)
						return;
					_MemberExp = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region ShipExp変更通知プロパティ
			private List<int> _ShipExp;
			[JsonProperty(PropertyName = "api_get_ship_exp")]
			public List<int> ShipExp
			{
				get
				{ return _ShipExp; }
				set
				{ 
					if (_ShipExp == value)
						return;
					_ShipExp = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region ExpLvUp変更通知プロパティ
			private List<List<int>> _ExpLvUp;
			[JsonProperty(PropertyName = "api_get_exp_lvup")]
			public List<List<int>> ExpLvUp
			{
				get
				{ return _ExpLvUp; }
				set
				{ 
					if (_ExpLvUp == value)
						return;
					_ExpLvUp = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region MapAreaName変更通知プロパティ
			private string _MapAreaName;
			[JsonProperty(PropertyName = "api_maparea_name")]
			public string MapAreaName
			{
				get
				{ return _MapAreaName; }
				set
				{ 
					if (_MapAreaName == value)
						return;
					_MapAreaName = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Detail変更通知プロパティ
			private string _Detail;
			[JsonProperty(PropertyName = "api_detail")]
			public string Detail
			{
				get
				{ return _Detail; }
				set
				{ 
					if (_Detail == value)
						return;
					_Detail = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region QuestName変更通知プロパティ
			private string _QuestName;
			[JsonProperty(PropertyName = "api_quest_name")]
			public string QuestName
			{
				get
				{ return _QuestName; }
				set
				{ 
					if (_QuestName == value)
						return;
					_QuestName = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region QuestLevel変更通知プロパティ
			private int _QuestLevel;
			[JsonProperty(PropertyName = "api_quest_level")]
			public int QuestLevel
			{
				get
				{ return _QuestLevel; }
				set
				{ 
					if (_QuestLevel == value)
						return;
					_QuestLevel = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region GetMaterial変更通知プロパティ
			private List<int> _GetMaterial;
			[JsonProperty(PropertyName = "api_get_material")]
			public List<int> GetMaterial
			{
				get
				{ return _GetMaterial; }
				set
				{ 
					if (_GetMaterial == value)
						return;
					_GetMaterial = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region UseItemFlag変更通知プロパティ
			private List<int> _UseItemFlag;
			[JsonProperty(PropertyName = "api_useitem_flag")]
			public List<int> UseItemFlag
			{
				get
				{ return _UseItemFlag; }
				set
				{ 
					if (_UseItemFlag == value)
						return;
					_UseItemFlag = value;
					RaisePropertyChanged();
				}
			}
			#endregion

		}
	}
}
