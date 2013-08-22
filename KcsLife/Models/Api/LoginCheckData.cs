using Livet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	public class LoginCheckData : ModelBase
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


		public class MyData : NotificationObject
		{

			#region AddMaterialFlag変更通知プロパティ
			private int _AddMaterialFlag;
			[JsonProperty(PropertyName = "api_add_material_flag")]
			public int AddMaterialFlag
			{
				get
				{ return _AddMaterialFlag; }
				set
				{
					if (_AddMaterialFlag == value)
						return;
					_AddMaterialFlag = value;
					RaisePropertyChanged();
				}
			}
			#endregion

		}
	}
}
