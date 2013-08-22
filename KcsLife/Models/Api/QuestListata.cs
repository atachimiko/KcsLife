using Livet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	public class QuestListata : ModelBase
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
			#region Count変更通知プロパティ
			private int _Count;
			[JsonProperty(PropertyName = "api_count")]
			public int Count
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


			#region PageCount変更通知プロパティ
			private int _PageCount;
			[JsonProperty(PropertyName = "api_page_count")]
			public int PageCount
			{
				get
				{ return _PageCount; }
				set
				{ 
					if (_PageCount == value)
						return;
					_PageCount = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region DispPage変更通知プロパティ
			private int _DispPage;
			[JsonProperty(PropertyName = "api_disp_page")]
			public int DispPage
			{
				get
				{ return _DispPage; }
				set
				{ 
					if (_DispPage == value)
						return;
					_DispPage = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region List変更通知プロパティ
			private List<ListData> _List;
			[JsonProperty(PropertyName = "api_list")]
			public List<ListData> List
			{
				get
				{ return _List; }
				set
				{ 
					if (_List == value)
						return;
					_List = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			public class ListData : NotificationObject
			{

				#region No変更通知プロパティ
				private int _No;
				[JsonProperty(PropertyName = "api_no")]
				public int No
				{
					get
					{ return _No; }
					set
					{ 
						if (_No == value)
							return;
						_No = value;
						RaisePropertyChanged();
					}
				}
				#endregion


				#region Category変更通知プロパティ
				private int _Category;
				[JsonProperty(PropertyName = "api_category")]
				public int Category
				{
					get
					{ return _Category; }
					set
					{ 
						if (_Category == value)
							return;
						_Category = value;
						RaisePropertyChanged();
					}
				}
				#endregion


				#region Type変更通知プロパティ
				private int _Type;
				[JsonProperty(PropertyName = "api_type")]
				public int Type
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



				#region Title変更通知プロパティ
				private string _Title;
				[JsonProperty(PropertyName = "api_title")]
				public string Title
				{
					get
					{ return _Title; }
					set
					{ 
						if (_Title == value)
							return;
						_Title = value;
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



				#region BonusFlag変更通知プロパティ
				private int _BonusFlag;
				[JsonProperty(PropertyName = "api_bonus_flag")]
				public int BonusFlag
				{
					get
					{ return _BonusFlag; }
					set
					{ 
						if (_BonusFlag == value)
							return;
						_BonusFlag = value;
						RaisePropertyChanged();
					}
				}
				#endregion


				#region NowCount変更通知プロパティ
				private int _NowCount;
				[JsonProperty(PropertyName = "api_now_count")]
				public int NowCount
				{
					get
					{ return _NowCount; }
					set
					{ 
						if (_NowCount == value)
							return;
						_NowCount = value;
						RaisePropertyChanged();
					}
				}
				#endregion


				#region ClearCount変更通知プロパティ
				private int _ClearCount;
				[JsonProperty(PropertyName = "api_clear_count")]
				public int ClearCount
				{
					get
					{ return _ClearCount; }
					set
					{ 
						if (_ClearCount == value)
							return;
						_ClearCount = value;
						RaisePropertyChanged();
					}
				}
				#endregion

			}
		}
	}
}
