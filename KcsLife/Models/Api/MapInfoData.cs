using Livet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	public class MapInfoData : ModelBase
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



			#region Level変更通知プロパティ
			private int _Level;
			[JsonProperty(PropertyName = "api_level")]
			public int Level
			{
				get
				{ return _Level; }
				set
				{ 
					if (_Level == value)
						return;
					_Level = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region OpeText変更通知プロパティ
			private string _OpeText;
			[JsonProperty(PropertyName = "api_opetext")]
			public string OpeText
			{
				get
				{ return _OpeText; }
				set
				{ 
					if (_OpeText == value)
						return;
					_OpeText = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region InfoText変更通知プロパティ
			private string _InfoText;
			[JsonProperty(PropertyName = "api_infotext")]
			public string InfoText
			{
				get
				{ return _InfoText; }
				set
				{ 
					if (_InfoText == value)
						return;
					_InfoText = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Item変更通知プロパティ
			private List<int> _Item;
			[JsonProperty(PropertyName = "api_item")]
			public List<int> Item
			{
				get
				{ return _Item; }
				set
				{ 
					if (_Item == value)
						return;
					_Item = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region MaxCell変更通知プロパティ
			private int _MaxCell;
			[JsonProperty(PropertyName = "api_maxcell")]
			public int MaxCell
			{
				get
				{ return _MaxCell; }
				set
				{ 
					if (_MaxCell == value)
						return;
					_MaxCell = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Active変更通知プロパティ
			private int _Active;
			[JsonProperty(PropertyName = "api_active")]
			public int Active
			{
				get
				{ return _Active; }
				set
				{ 
					if (_Active == value)
						return;
					_Active = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Cleared変更通知プロパティ
			private int _Cleared;
			[JsonProperty(PropertyName = "api_cleared")]
			public int Cleared
			{
				get
				{ return _Cleared; }
				set
				{ 
					if (_Cleared == value)
						return;
					_Cleared = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region ExBossFlag変更通知プロパティ
			private int _ExBossFlag;
			[JsonProperty(PropertyName = "api_exboss_flag")]
			public int ExBossFlag
			{
				get
				{ return _ExBossFlag; }
				set
				{ 
					if (_ExBossFlag == value)
						return;
					_ExBossFlag = value;
					RaisePropertyChanged();
				}
			}
			#endregion



			#region Progress変更通知プロパティ
			private double _Progress;
			[JsonProperty(PropertyName = "api_progress")]
			public double Progress
			{
				get
				{ return _Progress; }
				set
				{ 
					if (_Progress == value)
						return;
					_Progress = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region EventMap変更通知プロパティ
			private EventMapData _EventMap;
			[JsonProperty(PropertyName = "api_eventmap")]
			public EventMapData EventMap
			{
				get
				{ return _EventMap; }
				set
				{ 
					if (_EventMap == value)
						return;
					_EventMap = value;
					RaisePropertyChanged();
				}
			}
			#endregion



			public class EventMapData : NotificationObject
			{

				#region MaxMapHp変更通知プロパティ
				private int _MaxMapHp;
				[JsonProperty(PropertyName = "api_max_maphp")]
				public int MaxMapHp
				{
					get
					{ return _MaxMapHp; }
					set
					{ 
						if (_MaxMapHp == value)
							return;
						_MaxMapHp = value;
						RaisePropertyChanged();
					}
				}
				#endregion


				#region NowMapHp変更通知プロパティ
				private int _NowMapHp;
				[JsonProperty(PropertyName = "api_now_maphp")]
				public int NowMapHp
				{
					get
					{ return _NowMapHp; }
					set
					{ 
						if (_NowMapHp == value)
							return;
						_NowMapHp = value;
						RaisePropertyChanged();
					}
				}
				#endregion


				#region State変更通知プロパティ
				private int _State;
				[JsonProperty(PropertyName = "api_state")]
				public int State
				{
					get
					{ return _State; }
					set
					{ 
						if (_State == value)
							return;
						_State = value;
						RaisePropertyChanged();
					}
				}
				#endregion

			}
		}
	}
}
