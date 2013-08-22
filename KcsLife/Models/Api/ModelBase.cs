using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Livet;
using Newtonsoft.Json;

namespace KcsLife.Models.Api
{
	public abstract class ModelBase : NotificationObject
	{
		/*
		 * NotificationObjectはプロパティ変更通知の仕組みを実装したオブジェクトです。
		 */


		#region Result変更通知プロパティ
		private int _Result;
		[JsonProperty(PropertyName="api_result")]
		public int Result
		{
			get
			{ return _Result; }
			set
			{ 
				if (_Result == value)
					return;
				_Result = value;
				RaisePropertyChanged();
			}
		}
		#endregion



		#region ResultMessage変更通知プロパティ
		private string _ResultMessage;

		[JsonProperty(PropertyName = "api_result_msg")]
		public string ResultMessage
		{
			get
			{ return _ResultMessage; }
			set
			{ 
				if (_ResultMessage == value)
					return;
				_ResultMessage = value;
				RaisePropertyChanged();
			}
		}
		#endregion



	}

	public abstract class ApiDataItemBase : NotificationObject
	{
		#region MemberId変更通知プロパティ
		private int _MemberId;
		[JsonProperty(PropertyName = "api_member_id")]
		public int MemberId
		{
			get
			{ return _MemberId; }
			set
			{
				if (_MemberId == value)
					return;
				_MemberId = value;
				RaisePropertyChanged();
			}
		}
		#endregion



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


		#region State変更通知プロパティ
		private int _State;
		[JsonProperty(PropertyName = "api_state")]
		public int State
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
