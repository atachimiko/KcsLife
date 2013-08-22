using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	public class PracticeData : ModelBase
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


			#region EnemyName変更通知プロパティ
			private string _EnemyName;
			[JsonProperty(PropertyName = "api_enemy_name")]
			public string EnemyName
			{
				get
				{ return _EnemyName; }
				set
				{ 
					if (_EnemyName == value)
						return;
					_EnemyName = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region EnemyNameId変更通知プロパティ
			private string _EnemyNameId;
			[JsonProperty(PropertyName = "api_enemy_name_id")]
			public string EnemyNameId
			{
				get
				{ return _EnemyNameId; }
				set
				{ 
					if (_EnemyNameId == value)
						return;
					_EnemyNameId = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region EnemyLevel変更通知プロパティ
			private int _EnemyLevel;
			[JsonProperty(PropertyName = "api_enemy_level")]
			public int EnemyLevel
			{
				get
				{ return _EnemyLevel; }
				set
				{ 
					if (_EnemyLevel == value)
						return;
					_EnemyLevel = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region EnemyRank変更通知プロパティ
			private string _EnemyRank;
			[JsonProperty(PropertyName = "api_enemy_rank")]
			public string EnemyRank
			{
				get
				{ return _EnemyRank; }
				set
				{ 
					if (_EnemyRank == value)
						return;
					_EnemyRank = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region EnemyFlag変更通知プロパティ
			private int _EnemyFlag;
			[JsonProperty(PropertyName = "api_enemy_flag")]
			public int EnemyFlag
			{
				get
				{ return _EnemyFlag; }
				set
				{ 
					if (_EnemyFlag == value)
						return;
					_EnemyFlag = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region EnemyFlagShip変更通知プロパティ
			private int _EnemyFlagShip;
			[JsonProperty(PropertyName = "api_enemy_flag_ship")]
			public int EnemyFlagShip
			{
				get
				{ return _EnemyFlagShip; }
				set
				{ 
					if (_EnemyFlagShip == value)
						return;
					_EnemyFlagShip = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region EnemyComment変更通知プロパティ
			private string _EnemyComment;
			[JsonProperty(PropertyName = "api_enemy_comment")]
			public string EnemyComment
			{
				get
				{ return _EnemyComment; }
				set
				{ 
					if (_EnemyComment == value)
						return;
					_EnemyComment = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region EnemyCommentId変更通知プロパティ
			private string _EnemyCommentId;
			[JsonProperty(PropertyName = "api_enemy_comment_id")]
			public string EnemyCommentId
			{
				get
				{ return _EnemyCommentId; }
				set
				{ 
					if (_EnemyCommentId == value)
						return;
					_EnemyCommentId = value;
					RaisePropertyChanged();
				}
			}
			#endregion

		}
	}
}
