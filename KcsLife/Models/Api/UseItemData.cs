using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	public class UseItemData : ModelBase
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


			#region UseType変更通知プロパティ
			private int _UseType;
			[JsonProperty(PropertyName = "api_usetype")]
			public int UseType
			{
				get
				{ return _UseType; }
				set
				{ 
					if (_UseType == value)
						return;
					_UseType = value;
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



			#region Description変更通知プロパティ
			private List<string> _Description;
			[JsonProperty(PropertyName = "api_description")]
			public List<string> Description
			{
				get
				{ return _Description; }
				set
				{ 
					if (_Description == value)
						return;
					_Description = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Price変更通知プロパティ
			private int _Price;
			[JsonProperty(PropertyName = "api_price")]
			public int Price
			{
				get
				{ return _Price; }
				set
				{ 
					if (_Price == value)
						return;
					_Price = value;
					RaisePropertyChanged();
				}
			}
			#endregion


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

		}
	}
}
