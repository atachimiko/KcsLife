using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Livet;
using Newtonsoft.Json;

namespace KcsLife.Models.Api
{
	public class ActionLogData : ModelBase
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


		public class MyData : NotificationObject
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


			#region Type変更通知プロパティ
			private string _Type;
			[JsonProperty(PropertyName = "api_type")]
			public string Type
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
			private string _State;
			[JsonProperty(PropertyName = "api_state")]
			public string State
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



			#region Message変更通知プロパティ
			private string _Message;

			[JsonProperty(PropertyName = "api_message")]
			public string Message
			{
				get
				{ return _Message; }
				set
				{ 
					if (_Message == value)
						return;
					_Message = value;
					RaisePropertyChanged();
				}
			}
			#endregion

		}
	}
}
