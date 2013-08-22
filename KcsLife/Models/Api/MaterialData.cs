using Livet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	public class MaterialData : ModelBase
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

			#region Value変更通知プロパティ
			private int _Value;
			[JsonProperty(PropertyName = "api_value")]
			public int Value
			{
				get
				{ return _Value; }
				set
				{ 
					if (_Value == value)
						return;
					_Value = value;
					RaisePropertyChanged();
				}
			}
			#endregion

		}
	}
}
