using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Models
{
	public class ApplicationSettingsInfo
	{
		public void Load(StreamReader sr)
		{
			JsonConvert.PopulateObject(sr.ReadToEnd(), this);
		}


		#region Token変更通知プロパティ
		private string _Token;

		public string Token
		{
			get
			{ return _Token; }
			set
			{ 
				if (_Token == value)
					return;
				_Token = value;
			}
		}
		#endregion


		#region Referer変更通知プロパティ
		private string _Referer;

		public string Referer
		{
			get
			{ return _Referer; }
			set
			{ 
				if (_Referer == value)
					return;
				_Referer = value;
			}
		}
		#endregion

	}
}
