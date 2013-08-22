using Livet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models
{
	/// <summary>
	/// ログ
	/// </summary>
	public class LogInfo : NotificationObject
	{

		#region LogDate変更通知プロパティ
		private DateTime _LogDate;

		/// <summary>
		/// ログの日時
		/// </summary>
		public DateTime LogDate
		{
			get
			{ return _LogDate; }
			set
			{ 
				if (_LogDate == value)
					return;
				_LogDate = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region InfoType変更通知プロパティ
		private string _InfoType;

		/// <summary>
		/// ログの種類
		/// </summary>
		public string InfoType
		{
			get
			{ return _InfoType; }
			set
			{ 
				if (_InfoType == value)
					return;
				_InfoType = value;
				RaisePropertyChanged();
			}
		}
		#endregion


		#region Message変更通知プロパティ
		private string _Message;
		/// <summary>
		/// ログの内容
		/// </summary>
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


		#region DetailMessage変更通知プロパティ
		private string _DetailMessage;
		/// <summary>
		/// より詳しいログの内容。
		/// 不要な場合は空文字。
		/// </summary>
		public string DetailMessage
		{
			get
			{ return _DetailMessage; }
			set
			{ 
				if (_DetailMessage == value)
					return;
				_DetailMessage = value;
				RaisePropertyChanged();
			}
		}
		#endregion

	}
}
