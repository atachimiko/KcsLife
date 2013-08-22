using KcsLife.Models.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Gateways
{
	/// <summary>
	/// KCSサーバーへのリクエストを行うコンテキストクラス
	/// </summary>
	public class KcsRequestContext
	{
		public KcsRequestContext(Dictionary<string, string> apiPath, string baseurl, string referer)
		{
			this.ApiPathDict = apiPath;
			this.BaseUrl = baseurl;
			this.Referer = referer;
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


		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// Http通信では例外が発生する可能性があります。
		/// </remarks>
		/// <returns></returns>
		public async Task<LoginCheckData> LoginCheck()
		{
			var requestPath = this.ApiPathDict["logincheck"];
			var extraQuery = "";
			return await KcsHttpRequest<LoginCheckData>(requestPath, extraQuery);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public async Task<RecordData> Record()
		{
			var requestPath = this.ApiPathDict["record"];
			var extraQuery = "";
			return await KcsHttpRequest<RecordData>(requestPath, extraQuery);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public async Task<MapInfoData> MapInfo()
		{
			var requestPath = this.ApiPathDict["mapinfo"];
			var extraQuery = "";
			return await KcsHttpRequest<MapInfoData>(requestPath, extraQuery);
		}


		/// <summary>
		/// プレイヤーが所有する艦船リストを取得するAPIを呼び出します
		/// </summary>
		/// <returns></returns>
		public async Task<Ship2Data> Ship2()
		{
			var requestPath = this.ApiPathDict["ship2"];
			var extraQuery = "";
			return await KcsHttpRequest<Ship2Data>(requestPath, extraQuery);
		}


		async Task<T> KcsHttpRequest<T>(string path, string extraQuery)
		{
			T model = default(T);
			try
			{
				var client = HttpInitialize();

				var content = RequestQuery(extraQuery);
				content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

				string requestUrl = string.Format("http://{0}{1}", BaseUrl, path);
				HttpResponseMessage response = await client.PostAsync(requestUrl, content);
				string responseBody = await response.Content.ReadAsStringAsync();
				var jsonString = responseBody.Substring(7);
				model = JsonConvert.DeserializeObject<T>(jsonString);
			}
			catch (HttpRequestException e)
			{
				Console.WriteLine("\nException Caught!");
				Console.WriteLine("Message :{0} ", e.Message);
			}
			catch (Exception e)
			{
				Console.WriteLine("\nException Caught!");
				Console.WriteLine("Message :{0} ", e.Message);
			}

			return model;
		}



		ByteArrayContent RequestQuery(string custom)
		{
			if (string.IsNullOrEmpty(custom))
			{
				var s = string.Format("api%5Fverno=1&api%5Ftoken={0}", this.Token);
				return new ByteArrayContent(System.Text.Encoding.ASCII.GetBytes(
					s
				));
			}
			else
			{
				var s = string.Format("{1}&api%5Fverno=1&api%5Ftoken={0}", this.Token, custom);
				return new ByteArrayContent(System.Text.Encoding.ASCII.GetBytes(
					s
				));
			}
		}

		HttpClient HttpInitialize()
		{
			HttpClient client = new HttpClient();
			client.DefaultRequestHeaders.Referrer = new Uri(this.Referer);
			client.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
			client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0");

			return client;
		}

		readonly Dictionary<string, string> ApiPathDict;
		readonly string BaseUrl;
		readonly string Referer;
	}
}
