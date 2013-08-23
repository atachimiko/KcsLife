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

		public void Save(StreamWriter sw)
		{
			string json = JsonConvert.SerializeObject(this, Formatting.Indented);
			sw.Write(json);
		}


		#region BaseUrl変更通知プロパティ
		private string _BaseUrl;

		public string BaseUrl
		{
			get
			{ return _BaseUrl; }
			set
			{ 
				if (_BaseUrl == value)
					return;
				_BaseUrl = value;
			}
		}
		#endregion

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
