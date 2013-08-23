using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models.Api
{
	/// <summary>
	/// 補給リクエストに対するレスポンス
	/// </summary>
	public class ChargeData : ModelBase
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

			#region Fuel変更通知プロパティ
			private int _Fuel;
			[JsonProperty(PropertyName = "api_fuel")]
			public int Fuel
			{
				get
				{ return _Fuel; }
				set
				{ 
					if (_Fuel == value)
						return;
					_Fuel = value;
					RaisePropertyChanged();
				}
			}
			#endregion


			#region Bull変更通知プロパティ
			private int _Bull;
			[JsonProperty(PropertyName = "api_bull")]
			public int Bull
			{
				get
				{ return _Bull; }
				set
				{ 
					if (_Bull == value)
						return;
					_Bull = value;
					RaisePropertyChanged();
				}
			}
			#endregion



			#region OnSlot変更通知プロパティ
			private List<int> _OnSlot;
			[JsonProperty(PropertyName = "api_onslot")]
			public List<int> OnSlot
			{
				get
				{ return _OnSlot; }
				set
				{ 
					if (_OnSlot == value)
						return;
					_OnSlot = value;
					RaisePropertyChanged();
				}
			}
			#endregion

		}
	}
}
