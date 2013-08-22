using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	public class NdockData : ModelBase
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
			private int _ShipId;
			[JsonProperty(PropertyName = "api_ship_id")]
			public int ShipId
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


			#region CompleteTime変更通知プロパティ
			private int _CompleteTime;
			[JsonProperty(PropertyName = "api_complete_time")]
			public int CompleteTime
			{
				get
				{ return _CompleteTime; }
				set
				{ 
					if (_CompleteTime == value)
						return;
					_CompleteTime = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region CompleteTimeStr変更通知プロパティ
			private string _CompleteTimeStr;
			[JsonProperty(PropertyName = "api_complete_time_str")]
			public string CompleteTimeStr
			{
				get
				{ return _CompleteTimeStr; }
				set
				{ 
					if (_CompleteTimeStr == value)
						return;
					_CompleteTimeStr = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Item1変更通知プロパティ
			private int _Item1;
			[JsonProperty(PropertyName = "api_item1")]
			public int Item1
			{
				get
				{ return _Item1; }
				set
				{ 
					if (_Item1 == value)
						return;
					_Item1 = value;
					RaisePropertyChanged();
				}
			}
			#endregion

			#region Item2変更通知プロパティ
			private int _Item2;
			[JsonProperty(PropertyName = "api_item2")]
			public int Item2
			{
				get
				{ return _Item2; }
				set
				{
					if (_Item2 == value)
						return;
					_Item2 = value;
					RaisePropertyChanged();
				}
			}
			#endregion

			#region Item3変更通知プロパティ
			private int _Item3;
			[JsonProperty(PropertyName = "api_item3")]
			public int Item3
			{
				get
				{ return _Item3; }
				set
				{
					if (_Item3 == value)
						return;
					_Item3 = value;
					RaisePropertyChanged();
				}
			}
			#endregion

			#region Item4変更通知プロパティ
			private int _Item4;
			[JsonProperty(PropertyName = "api_item4")]
			public int Item4
			{
				get
				{ return _Item4; }
				set
				{
					if (_Item4 == value)
						return;
					_Item4 = value;
					RaisePropertyChanged();
				}
			}
			#endregion
		}
	}
}
