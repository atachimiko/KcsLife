using Livet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	public class DeckPortData : ModelBase
	{
		#region Data変更通知プロパティ
		private List<MyApiData> _Data;
		[JsonProperty(PropertyName = "api_data")]
		public List<MyApiData> Data
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

		public class MyApiData : ApiDataItemBase
		{
			#region Id変更通知プロパティ
			private int _Id;
			[JsonProperty(PropertyName = "api_id")]
			public int Id
			{
				get
				{ return _Id; }
				set
				{
					if (_Id == value)
						return;
					_Id = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Name変更通知プロパティ
			private string _Name;
			[JsonProperty(PropertyName = "api_name")]
			public string Name
			{
				get
				{ return _Name; }
				set
				{ 
					if (_Name == value)
						return;
					_Name = value;
					RaisePropertyChanged();
				}
			}
			#endregion

			#region NameId変更通知プロパティ
			private string _NameId;
			[JsonProperty(PropertyName = "api_name_id")]
			public string NameId
			{
				get
				{ return _NameId; }
				set
				{
					if (_NameId == value)
						return;
					_NameId = value;
					RaisePropertyChanged();
				}
			}
			#endregion

			
			#region Mission変更通知プロパティ
			private List<long> _Mission;
			[JsonProperty(PropertyName = "api_mission")]
			public List<long> Mission
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


			#region Flagship変更通知プロパティ
			private string _Flagship;
			[JsonProperty(PropertyName = "api_flagship")]
			public string Flagship
			{
				get
				{ return _Flagship; }
				set
				{ 
					if (_Flagship == value)
						return;
					_Flagship = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Ship変更通知プロパティ
			private List<long> _Ship;
			[JsonProperty(PropertyName = "api_ship")]
			public List<long> Ship
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
