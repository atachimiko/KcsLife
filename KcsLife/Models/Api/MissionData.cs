using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	class MissionData: ModelBase
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


			#region Details変更通知プロパティ
			private string _Details;
			[JsonProperty(PropertyName = "api_details")]
			public string Details
			{
				get
				{ return _Details; }
				set
				{ 
					if (_Details == value)
						return;
					_Details = value;
					RaisePropertyChanged();
				}
			}
			#endregion

			#region Time変更通知プロパティ
			private int _Time;
			[JsonProperty(PropertyName = "api_time")]
			public int Time
			{
				get
				{ return _Time; }
				set
				{ 
					if (_Time == value)
						return;
					_Time = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Difficulty変更通知プロパティ
			private int _Difficulty;
			[JsonProperty(PropertyName = "api_difficulty")]
			public int Difficulty
			{
				get
				{ return _Difficulty; }
				set
				{ 
					if (_Difficulty == value)
						return;
					_Difficulty = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region UseFuel変更通知プロパティ
			private double _UseFuel;
			[JsonProperty(PropertyName = "api_use_fuel")]
			public double UseFuel
			{
				get
				{ return _UseFuel; }
				set
				{ 
					if (_UseFuel == value)
						return;
					_UseFuel = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region UseBull変更通知プロパティ
			private double _UseBull;
			[JsonProperty(PropertyName = "api_use_bull")]
			public double UseBull
			{
				get
				{ return _UseBull; }
				set
				{ 
					if (_UseBull == value)
						return;
					_UseBull = value;
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


			#region WinItem1変更通知プロパティ
			private List<int> _WinItem1;
			[JsonProperty(PropertyName = "api_win_item1")]
			public List<int> WinItem1
			{
				get
				{ return _WinItem1; }
				set
				{ 

					if (_WinItem1 == value)
						return;
					_WinItem1 = value;
					RaisePropertyChanged();
				}
			}
			#endregion

			#region WinItem2変更通知プロパティ
			private List<int> _WinItem2;
			[JsonProperty(PropertyName = "api_win_item2")]
			public List<int> WinItem2
			{
				get
				{ return _WinItem2; }
				set
				{

					if (_WinItem2 == value)
						return;
					_WinItem1 = value;
					RaisePropertyChanged();
				}
			}
			#endregion
		}
	}
}
