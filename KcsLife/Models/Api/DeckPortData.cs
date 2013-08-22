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
		}
	}
}
