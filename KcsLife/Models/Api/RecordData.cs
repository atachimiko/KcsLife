using Livet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	public class RecordData : ModelBase
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
			[JsonProperty(PropertyName = "api_nickname_id")]
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


			#region Cmt変更通知プロパティ
			private string _Cmt;
			[JsonProperty(PropertyName = "api_cmt")]
			public string Cmt
			{
				get
				{ return _Cmt; }
				set
				{ 
					if (_Cmt == value)
						return;
					_Cmt = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region CmtId変更通知プロパティ
			private string _CmtId;
			[JsonProperty(PropertyName = "api_cmt_id")]
			public string CmtId
			{
				get
				{ return _CmtId; }
				set
				{ 
					if (_CmtId == value)
						return;
					_CmtId = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region PhotoUrl変更通知プロパティ
			private string _PhotoUrl;
			[JsonProperty(PropertyName = "api_photo_url")]
			public string PhotoUrl
			{
				get
				{ return _PhotoUrl; }
				set
				{ 
					if (_PhotoUrl == value)
						return;
					_PhotoUrl = value;
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
			private List<int> _Experience;
			[JsonProperty(PropertyName = "api_experience")]
			public List<int> Experience
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



			#region Friend変更通知プロパティ
			private int _Friend;
			[JsonProperty(PropertyName = "api_friend")]
			public int Friend
			{
				get
				{ return _Friend; }
				set
				{ 
					if (_Friend == value)
						return;
					_Friend = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Deck変更通知プロパティ
			private int _Deck;
			[JsonProperty(PropertyName = "api_deck")]
			public int Deck
			{
				get
				{ return _Deck; }
				set
				{ 
					if (_Deck == value)
						return;
					_Deck = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Kdoc変更通知プロパティ
			private int _Kdoc;
			[JsonProperty(PropertyName = "api_kdoc")]
			public int Kdoc
			{
				get
				{ return _Kdoc; }
				set
				{ 
					if (_Kdoc == value)
						return;
					_Kdoc = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Ndoc変更通知プロパティ
			private int _Ndoc;
			[JsonProperty(PropertyName = "api_ndoc")]
			public int Ndoc
			{
				get
				{ return _Ndoc; }
				set
				{ 
					if (_Ndoc == value)
						return;
					_Ndoc = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Ship変更通知プロパティ
			private List<int> _Ship;
			[JsonProperty(PropertyName = "api_ship")]
			public List<int> Ship
			{
				get
				{ return _Ship; }
				set
				{ 
					if (_Ship == value)
						return;
					_Ship = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region SlotItem変更通知プロパティ
			private List<int> _SlotItem;
			[JsonProperty(PropertyName = "api_slotitem")]
			public List<int> SlotItem
			{
				get
				{ return _SlotItem; }
				set
				{ 
					if (_SlotItem == value)
						return;
					_SlotItem = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Furniture変更通知プロパティ
			private int _Furniture;
			[JsonProperty(PropertyName = "api_furniture")]
			public int Furniture
			{
				get
				{ return _Furniture; }
				set
				{ 
					if (_Furniture == value)
						return;
					_Furniture = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Complete変更通知プロパティ
			private List<string> _Complete;
			[JsonProperty(PropertyName = "api_complete")]
			public List<string> Complete
			{
				get
				{ return _Complete; }
				set
				{ 
					if (_Complete == value)
						return;
					_Complete = value;
					RaisePropertyChanged();
				}
			}
			#endregion



			#region MaterialMax変更通知プロパティ
			private int _MaterialMax;
			[JsonProperty(PropertyName = "api_material_max")]
			public int MaterialMax
			{
				get
				{ return _MaterialMax; }
				set
				{ 
					if (_MaterialMax == value)
						return;
					_MaterialMax = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region War変更通知プロパティ
			private WarData _War;
			[JsonProperty(PropertyName = "api_war")]
			public WarData War
			{
				get
				{ return _War; }
				set
				{ 
					if (_War == value)
						return;
					_War = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Mission変更通知プロパティ
			private MissionData _Mission;
			[JsonProperty(PropertyName = "api_mission")]
			public MissionData Mission
			{
				get
				{ return _Mission; }
				set
				{ 
					if (_Mission == value)
						return;
					_Mission = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Practice変更通知プロパティ
			private PracticeData _Practice;
			[JsonProperty(PropertyName = "api_practice")]
			public PracticeData Practice
			{
				get
				{ return _Practice; }
				set
				{ 
					if (_Practice == value)
						return;
					_Practice = value;
					RaisePropertyChanged();
				}
			}
			#endregion

		}

		public class WarData : NotificationObject
		{

			#region Win変更通知プロパティ
			private string _Win;
			[JsonProperty(PropertyName = "api_win")]
			public string Win
			{
				get
				{ return _Win; }
				set
				{ 
					if (_Win == value)
						return;
					_Win = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Lose変更通知プロパティ
			private string _Lose;
			[JsonProperty(PropertyName = "api_lose")]
			public string Lose
			{
				get
				{ return _Lose; }
				set
				{ 
					if (_Lose == value)
						return;
					_Lose = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Rate変更通知プロパティ
			private string _Rate;
			[JsonProperty(PropertyName = "api_rate")]
			public string Rate
			{
				get
				{ return _Rate; }
				set
				{ 
					if (_Rate == value)
						return;
					_Rate = value;
					RaisePropertyChanged();
				}
			}
			#endregion
		}

		public class MissionData : NotificationObject
		{

			#region Count変更通知プロパティ
			private string _Count;
			[JsonProperty(PropertyName = "api_count")]
			public string Count
			{
				get
				{ return _Count; }
				set
				{ 
					if (_Count == value)
						return;
					_Count = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Success変更通知プロパティ
			private string _Success;
			[JsonProperty(PropertyName = "api_success")]
			public string Success
			{
				get
				{ return _Success; }
				set
				{ 
					if (_Success == value)
						return;
					_Success = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Rate変更通知プロパティ
			private string _Rate;
			[JsonProperty(PropertyName = "api_rate")]
			public string Rate
			{
				get
				{ return _Rate; }
				set
				{ 
					if (_Rate == value)
						return;
					_Rate = value;
					RaisePropertyChanged();
				}
			}
			#endregion
		}

		public class PracticeData : NotificationObject
		{
			#region Win変更通知プロパティ
			private string _Win;
			[JsonProperty(PropertyName = "api_win")]
			public string Win
			{
				get
				{ return _Win; }
				set
				{
					if (_Win == value)
						return;
					_Win = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Lose変更通知プロパティ
			private string _Lose;
			[JsonProperty(PropertyName = "api_lose")]
			public string Lose
			{
				get
				{ return _Lose; }
				set
				{
					if (_Lose == value)
						return;
					_Lose = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Rate変更通知プロパティ
			private string _Rate;
			[JsonProperty(PropertyName = "api_rate")]
			public string Rate
			{
				get
				{ return _Rate; }
				set
				{
					if (_Rate == value)
						return;
					_Rate = value;
					RaisePropertyChanged();
				}
			}
			#endregion
		}
	}
}
