using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	public class DeckData: ModelBase
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

			#region Mission変更通知プロパティ
			private List<int> _Mission;
			[JsonProperty(PropertyName = "api_mission")]
			public List<int> Mission
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


			#region FlagShip変更通知プロパティ
			private string _FlagShip;
			[JsonProperty(PropertyName = "api_flagship")]
			public string FlagShip
			{
				get
				{ return _FlagShip; }
				set
				{ 
					if (_FlagShip == value)
						return;
					_FlagShip = value;
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

		}
	}
}
