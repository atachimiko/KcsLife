using Livet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	public class StartData: ModelBase
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

			#region RashinFlg変更通知プロパティ
			private int _RashinFlg;
			[JsonProperty(PropertyName = "api_rashin_flg")]
			public int RashinFlg
			{
				get
				{ return _RashinFlg; }
				set
				{ 
					if (_RashinFlg == value)
						return;
					_RashinFlg = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region RashinId変更通知プロパティ
			private int _RashinId;
			[JsonProperty(PropertyName = "api_rashin_id")]
			public int RashinId
			{
				get
				{ return _RashinId; }
				set
				{ 
					if (_RashinId == value)
						return;
					_RashinId = value;
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


			#region EventId変更通知プロパティ
			private int _EventId;
			[JsonProperty(PropertyName = "api_event_id")]
			public int EventId
			{
				get
				{ return _EventId; }
				set
				{ 
					if (_EventId == value)
						return;
					_EventId = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Next変更通知プロパティ
			private int _Next;
			[JsonProperty(PropertyName = "api_next")]
			public int Next
			{
				get
				{ return _Next; }
				set
				{ 
					if (_Next == value)
						return;
					_Next = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region BossCellNo変更通知プロパティ
			private int _BossCellNo;
			[JsonProperty(PropertyName = "api_bosscell_no")]
			public int BossCellNo
			{
				get
				{ return _BossCellNo; }
				set
				{ 
					if (_BossCellNo == value)
						return;
					_BossCellNo = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region BossComp変更通知プロパティ
			private int _BossComp;
			[JsonProperty(PropertyName = "api_bosscomp")]
			public int BossComp
			{
				get
				{ return _BossComp; }
				set
				{ 
					if (_BossComp == value)
						return;
					_BossComp = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Enemy変更通知プロパティ
			private EnemyData _Enemy;
			[JsonProperty(PropertyName = "api_enemy")]
			public EnemyData Enemy
			{
				get
				{ return _Enemy; }
				set
				{ 
					if (_Enemy == value)
						return;
					_Enemy = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			public class EnemyData : NotificationObject
			{

				#region EnemyId変更通知プロパティ
				private int _EnemyId;
				[JsonProperty(PropertyName = "api_enemy_id")]
				public int EnemyId
				{
					get
					{ return _EnemyId; }
					set
					{ 
						if (_EnemyId == value)
							return;
						_EnemyId = value;
						RaisePropertyChanged();
					}
				}
				#endregion


				#region Result変更通知プロパティ
				private int _Result;
				[JsonProperty(PropertyName = "api_rsult")]
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


				#region ResultStr変更通知プロパティ
				private string _ResultStr;
				[JsonProperty(PropertyName = "api_result_str")]
				public string ResultStr
				{
					get
					{ return _ResultStr; }
					set
					{ 
						if (_ResultStr == value)
							return;
						_ResultStr = value;
						RaisePropertyChanged();
					}
				}
				#endregion

			}
		}
	}
}
