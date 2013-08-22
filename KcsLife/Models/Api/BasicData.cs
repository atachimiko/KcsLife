using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	public class BasicData : ModelBase
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

			#region Nickname変更通知プロパティ
			private string _Nickname;
			[JsonProperty(PropertyName = "api_nickname")]
			public string Nickname
			{
				get
				{ return _Nickname; }
				set
				{ 
					if (_Nickname == value)
						return;
					_Nickname = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region NicknameId変更通知プロパティ
			private string _NicknameId;
			[JsonProperty(PropertyName = "api_nikname_id")]
			public string NicknameId
			{
				get
				{ return _NicknameId; }
				set
				{ 
					if (_NicknameId == value)
						return;
					_NicknameId = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region ActiveFlag変更通知プロパティ
			private int _ActiveFlag;
			[JsonProperty(PropertyName = "api_active_flag")]
			public int ActiveFlag
			{
				get
				{ return _ActiveFlag; }
				set
				{ 
					if (_ActiveFlag == value)
						return;
					_ActiveFlag = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region StartTime変更通知プロパティ
			private int _StartTime;
			[JsonProperty(PropertyName = "api_starttime")]
			public int StartTime
			{
				get
				{ return _StartTime; }
				set
				{ 
					if (_StartTime == value)
						return;
					_StartTime = value;
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


			#region Rank変更通知プロパティ
			private int _Rank;
			[JsonProperty(PropertyName = "api_rank")]
			public int Rank
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


			#region Experience変更通知プロパティ
			private int _Experience;
			[JsonProperty(PropertyName = "api_experience")]
			public int Experience
			{
				get
				{ return _Experience; }
				set
				{ 
					if (_Experience == value)
						return;
					_Experience = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region FreetName変更通知プロパティ
			private string _FreetName;
			[JsonProperty(PropertyName = "api_freetname")]
			public string FreetName
			{
				get
				{ return _FreetName; }
				set
				{ 
					if (_FreetName == value)
						return;
					_FreetName = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Comment変更通知プロパティ
			private string _Comment;
			[JsonProperty(PropertyName = "api_omment")]
			public string Comment
			{
				get
				{ return _Comment; }
				set
				{ 
					if (_Comment == value)
						return;
					_Comment = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region CommentId変更通知プロパティ
			private string _CommentId;
			[JsonProperty(PropertyName = "api_comment_id")]
			public string CommentId
			{
				get
				{ return _CommentId; }
				set
				{ 
					if (_CommentId == value)
						return;
					_CommentId = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region MaxChara変更通知プロパティ
			private int _MaxChara;
			[JsonProperty(PropertyName = "api_max_chara")]
			public int MaxChara
			{
				get
				{ return _MaxChara; }
				set
				{ 
					if (_MaxChara == value)
						return;
					_MaxChara = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region MaxSlotItem変更通知プロパティ
			private int _MaxSlotItem;
			[JsonProperty(PropertyName = "api_max_slotitem")]
			public int MaxSlotItem
			{
				get
				{ return _MaxSlotItem; }
				set
				{ 
					if (_MaxSlotItem == value)
						return;
					_MaxSlotItem = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region MaxLagu変更通知プロパティ
			private int _MaxLagu;
			[JsonProperty(PropertyName = "api_max_kagu")]
			public int MaxLagu
			{
				get
				{ return _MaxLagu; }
				set
				{ 
					if (_MaxLagu == value)
						return;
					_MaxLagu = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region PlayTime変更通知プロパティ
			private int _PlayTime;
			[JsonProperty(PropertyName = "api_playtime")]
			public int PlayTime
			{
				get
				{ return _PlayTime; }
				set
				{ 
					if (_PlayTime == value)
						return;
					_PlayTime = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Tutorial変更通知プロパティ
			private int _Tutorial;
			[JsonProperty(PropertyName = "api_tutorial")]
			public int Tutorial
			{
				get
				{ return _Tutorial; }
				set
				{ 
					if (_Tutorial == value)
						return;
					_Tutorial = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Furniure変更通知プロパティ
			private List<int> _Furniure;
			[JsonProperty(PropertyName = "api_furniture")]
			public List<int> Furniure
			{
				get
				{ return _Furniure; }
				set
				{ 

					if (_Furniure == value)
						return;
					_Furniure = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region CountDeck変更通知プロパティ
			private int _CountDeck;
			[JsonProperty(PropertyName = "api_count_deck")]
			public int CountDeck
			{
				get
				{ return _CountDeck; }
				set
				{ 
					if (_CountDeck == value)
						return;
					_CountDeck = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region CountKdock変更通知プロパティ
			private int _CountKdock;
			[JsonProperty(PropertyName = "api_count_kdock")]
			public int CountKdock
			{
				get
				{ return _CountKdock; }
				set
				{ 
					if (_CountKdock == value)
						return;
					_CountKdock = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region CountNdock変更通知プロパティ
			private int _CountNdock;
			[JsonProperty(PropertyName = "api_count_ndock")]
			public int CountNdock
			{
				get
				{ return _CountNdock; }
				set
				{ 
					if (_CountNdock == value)
						return;
					_CountNdock = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Fcoin変更通知プロパティ
			private int _Fcoin;
			[JsonProperty(PropertyName = "api_fcoin")]
			public int Fcoin
			{
				get
				{ return _Fcoin; }
				set
				{ 
					if (_Fcoin == value)
						return;
					_Fcoin = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region StWin変更通知プロパティ
			private int _StWin;
			[JsonProperty(PropertyName = "api_st_win")]
			public int StWin
			{
				get
				{ return _StWin; }
				set
				{ 
					if (_StWin == value)
						return;
					_StWin = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region StLose変更通知プロパティ
			private int _StLose;
			[JsonProperty(PropertyName = "api_st_lose")]
			public int StLose
			{
				get
				{ return _StLose; }
				set
				{ 
					if (_StLose == value)
						return;
					_StLose = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region MsCount変更通知プロパティ
			private int _MsCount;
			[JsonProperty(PropertyName = "api_ms_count")]
			public int MsCount
			{
				get
				{ return _MsCount; }
				set
				{ 
					if (_MsCount == value)
						return;
					_MsCount = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region MsSuccess変更通知プロパティ
			private int _MsSuccess;
			[JsonProperty(PropertyName = "api_ms_success")]
			public int MsSuccess
			{
				get
				{ return _MsSuccess; }
				set
				{ 
					if (_MsSuccess == value)
						return;
					_MsSuccess = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region PtWin変更通知プロパティ
			private int _PtWin;
			[JsonProperty(PropertyName = "api_pt_win")]
			public int PtWin
			{
				get
				{ return _PtWin; }
				set
				{ 
					if (_PtWin == value)
						return;
					_PtWin = value;
					RaisePropertyChanged();
				}
			}
			#endregion



			#region PtLose変更通知プロパティ
			private int _PtLose;
			[JsonProperty(PropertyName = "api_pt_lose")]
			public int PtLose
			{
				get
				{ return _PtLose; }
				set
				{ 
					if (_PtLose == value)
						return;
					_PtLose = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region PtChallenged変更通知プロパティ
			private int _PtChallenged;
			[JsonProperty(PropertyName = "api_pt_challenged")]
			public int PtChallenged
			{
				get
				{ return _PtChallenged; }
				set
				{ 
					if (_PtChallenged == value)
						return;
					_PtChallenged = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region PtChallengedWin変更通知プロパティ
			private int _PtChallengedWin;
			[JsonProperty(PropertyName = "api_pt_challenged_win")]
			public int PtChallengedWin
			{
				get
				{ return _PtChallengedWin; }
				set
				{ 
					if (_PtChallengedWin == value)
						return;
					_PtChallengedWin = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region FirstFlag変更通知プロパティ
			private int _FirstFlag;
			[JsonProperty(PropertyName = "api_firstflag")]
			public int FirstFlag
			{
				get
				{ return _FirstFlag; }
				set
				{ 
					if (_FirstFlag == value)
						return;
					_FirstFlag = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region TutorialProgress変更通知プロパティ
			private int _TutorialProgress;
			[JsonProperty(PropertyName = "api_tutorial_progress")]
			public int TutorialProgress
			{
				get
				{ return _TutorialProgress; }
				set
				{ 
					if (_TutorialProgress == value)
						return;
					_TutorialProgress = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Pvp変更通知プロパティ
			private List<int> _Pvp;
			[JsonProperty(PropertyName = "api_pvp")]
			public List<int> Pvp
			{
				get
				{ return _Pvp; }
				set
				{ 
					if (_Pvp == value)
						return;
					_Pvp = value;
					RaisePropertyChanged();
				}
			}
			#endregion

		}
	}
}
