using Livet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	public class BattleResultData : ModelBase
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
			/// <summary>
			/// 戦闘を行った艦隊に所属している船IDのリスト
			/// </summary>
			/// <remarks>
			/// 空きスペースは「-1」が入ります。
			/// </remarks>
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


			#region WinRank変更通知プロパティ
			private string _WinRank;
			[JsonProperty(PropertyName = "api_win_rank")]
			public string WinRank
			{
				get
				{ return _WinRank; }
				set
				{ 
					if (_WinRank == value)
						return;
					_WinRank = value;
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


			#region Mvp変更通知プロパティ
			private int _Mvp;
			/// <summary>
			/// MVPを取得した船の位置を示すインデックス
			/// </summary>
			/// <remarks>
			/// ShipIdプロパティでの配列の添え字です。
			/// </remarks>
			[JsonProperty(PropertyName = "api_mvp")]
			public int Mvp
			{
				get
				{ return _Mvp; }
				set
				{ 
					if (_Mvp == value)
						return;
					_Mvp = value;
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



			#region GetBaseExp変更通知プロパティ
			private int _GetBaseExp;
			[JsonProperty(PropertyName = "api_get_base_exp")]
			public int GetBaseExp
			{
				get
				{ return _GetBaseExp; }
				set
				{ 
					if (_GetBaseExp == value)
						return;
					_GetBaseExp = value;
					RaisePropertyChanged();
				}
			}
			#endregion



			#region GetShipExp変更通知プロパティ
			private List<int> _GetShipExp;
			/// <summary>
			/// 艦隊内の各船が取得した経験値のコレクション
			/// </summary>
			/// <remarks>
			/// ShipIdプロパティの要素順番と同期する。
			/// 取得する経験値が存在しない場合は「-1」となります。
			/// </remarks>
			[JsonProperty(PropertyName = "api_get_ship_exp")]
			public List<int> GetShipExp
			{
				get
				{ return _GetShipExp; }
				set
				{ 
					if (_GetShipExp == value)
						return;
					_GetShipExp = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region GetExpLvUp変更通知プロパティ
			private List<List<int>> _GetExpLvUp;
			[JsonProperty(PropertyName = "api_get_exp_lvup")]
			public List<List<int>> GetExpLvUp
			{
				get
				{ return _GetExpLvUp; }
				set
				{ 
					if (_GetExpLvUp == value)
						return;
					_GetExpLvUp = value;
					RaisePropertyChanged();
				}
			}
			#endregion



			#region Dests変更通知プロパティ
			private int _Dests;
			[JsonProperty(PropertyName = "api_dests")]
			public int Dests
			{
				get
				{ return _Dests; }
				set
				{ 
					if (_Dests == value)
						return;
					_Dests = value;
					RaisePropertyChanged();
				}
			}
			#endregion



			#region LostFlag変更通知プロパティ
			private List<int> _LostFlag;
			/// <summary>
			/// 艦隊内の船がロストしたかどうかのフラグ
			/// </summary>
			/// <remarks>
			/// ShipIdプロパティで取得できるコレクションの項目順序と同期。
			/// 0番目はロストしない仕様のためか常に「-1」の値となる。
			/// </remarks>
			[JsonProperty(PropertyName = "api_lost_flag")]
			public List<int> LostFlag
			{
				get
				{ return _LostFlag; }
				set
				{ 
					if (_LostFlag == value)
						return;
					_LostFlag = value;
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


			#region EnemyInfo変更通知プロパティ
			private EnemyInfoData _EnemyInfo;
			[JsonProperty(PropertyName = "api_enemy_info")]
			public EnemyInfoData EnemyInfo
			{
				get
				{ return _EnemyInfo; }
				set
				{ 
					if (_EnemyInfo == value)
						return;
					_EnemyInfo = value;
					RaisePropertyChanged();
				}
			}
			#endregion



			#region FirstClear変更通知プロパティ
			private int _FirstClear;
			[JsonProperty(PropertyName = "api_first_clear")]
			public int FirstClear
			{
				get
				{ return _FirstClear; }
				set
				{ 
					if (_FirstClear == value)
						return;
					_FirstClear = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region GetFlag変更通知プロパティ
			private List<int> _GetFlag;
			[JsonProperty(PropertyName = "api_get_flag")]
			public List<int> GetFlag
			{
				get
				{ return _GetFlag; }
				set
				{ 
					if (_GetFlag == value)
						return;
					_GetFlag = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region GetShip変更通知プロパティ
			private GetShipData _GetShip;
			[JsonProperty(PropertyName = "api_get_ship")]
			public GetShipData GetShip
			{
				get
				{ return _GetShip; }
				set
				{ 
					if (_GetShip == value)
						return;
					_GetShip = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region GetEventFlag変更通知プロパティ
			private int _GetEventFlag;
			[JsonProperty(PropertyName = "api_get_eventflag")]
			public int GetEventFlag
			{
				get
				{ return _GetEventFlag; }
				set
				{ 
					if (_GetEventFlag == value)
						return;
					_GetEventFlag = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			public class EnemyInfoData : NotificationObject
			{

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


				#region Rank変更通知プロパティ
				private string _Rank;
				[JsonProperty(PropertyName = "api_rank")]
				public string Rank
				{
					get
					{ return _Rank; }
					set
					{ 
						if (_Rank == value)
							return;
						_Rank = value;
						RaisePropertyChanged();
					}
				}
				#endregion


				#region DeckName変更通知プロパティ
				private string _DeckName;
				[JsonProperty(PropertyName = "api_deck_name")]
				public string DeckName
				{
					get
					{ return _DeckName; }
					set
					{ 
						if (_DeckName == value)
							return;
						_DeckName = value;
						RaisePropertyChanged();
					}
				}
				#endregion
			}

			public class GetShipData : NotificationObject
			{

				#region ShipId変更通知プロパティ
				private string _ShipId;
				[JsonProperty(PropertyName = "api_ship_id")]
				public string ShipId
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


				#region ShipType変更通知プロパティ
				private string _ShipType;
				[JsonProperty(PropertyName = "api_ship_type")]
				public string ShipType
				{
					get
					{ return _ShipType; }
					set
					{ 
						if (_ShipType == value)
							return;
						_ShipType = value;
						RaisePropertyChanged();
					}
				}
				#endregion


				#region ShipName変更通知プロパティ
				private string _ShipName;
				[JsonProperty(PropertyName = "api_ship_name")]
				public string ShipName
				{
					get
					{ return _ShipName; }
					set
					{ 
						if (_ShipName == value)
							return;
						_ShipName = value;
						RaisePropertyChanged();
					}
				}
				#endregion


				#region ShipGetmes変更通知プロパティ
				private string _ShipGetmes;
				[JsonProperty(PropertyName = "api_ship_getmes")]
				public string ShipGetmes
				{
					get
					{ return _ShipGetmes; }
					set
					{ 
						if (_ShipGetmes == value)
							return;
						_ShipGetmes = value;
						RaisePropertyChanged();
					}
				}
				#endregion

			}
		}
	}
}
