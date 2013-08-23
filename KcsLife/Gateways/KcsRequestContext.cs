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
		/// <returns></returns>
		public async Task<ActionLogData> LoadActionLog()
		{
			var requestPath = this.ApiPathDict["actionlog"];
			var extraQuery = "";
			return await KcsHttpRequest<ActionLogData>(requestPath, extraQuery);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public async Task<BasicData> LoadBasic()
		{
			var requestPath = this.ApiPathDict["basic"];
			var extraQuery = "";
			return await KcsHttpRequest<BasicData>(requestPath, extraQuery);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public async Task<ChargeData> LoadCharge(List<ShipData> chargeShips)
		{
			List<int> ids = new List<int>();
			foreach (var p in chargeShips)
			{
				ids.Add(p.Id);
			}

			var chargeShipsText = string.Join(",", ids);
			chargeShipsText = chargeShipsText.Replace(",", "%2C");

			var requestPath = this.ApiPathDict["charge"];
			var extraQuery = string.Format("api_kind={0}&api_id_items={1}", 3, chargeShipsText);
			return await KcsHttpRequest<ChargeData>(requestPath, extraQuery);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// Http通信では例外が発生する可能性があります。
		/// </remarks>
		/// <returns></returns>
		public async Task<LoginCheckData> LoadLoginCheck()
		{
			var requestPath = this.ApiPathDict["logincheck"];
			var extraQuery = "";
			return await KcsHttpRequest<LoginCheckData>(requestPath, extraQuery);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public async Task<MaterialData> LoadMaterial()
		{
			var requestPath = this.ApiPathDict["material"];
			var extraQuery = "";
			return await KcsHttpRequest<MaterialData>(requestPath, extraQuery);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public async Task<DeckData> LoadDeck()
		{
			var requestPath = this.ApiPathDict["deck"];
			var extraQuery = "";
			return await KcsHttpRequest<DeckData>(requestPath, extraQuery);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public async Task<DeckPortData> LoadDeckPort()
		{
			var requestPath = this.ApiPathDict["deck_port"];
			var extraQuery = "";
			return await KcsHttpRequest<DeckPortData>(requestPath, extraQuery);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public async Task<NdockData> LoadNDock()
		{
			var requestPath = this.ApiPathDict["ndock"];
			var extraQuery = "";
			return await KcsHttpRequest<NdockData>(requestPath, extraQuery);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public async Task<RecordData> LoadRecord()
		{
			var requestPath = this.ApiPathDict["record"];
			var extraQuery = "";
			return await KcsHttpRequest<RecordData>(requestPath, extraQuery);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public async Task<MapInfoData> LoadMapInfo()
		{
			var requestPath = this.ApiPathDict["mapinfo"];
			var extraQuery = "";
			return await KcsHttpRequest<MapInfoData>(requestPath, extraQuery);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="mapareaId">出撃先の海域マップID</param>
		/// <param name="mapinfoId">出撃先のマップID</param>
		/// <returns></returns>
		public async Task<MapCellData> LoadMapCell(int mapinfoId,int mapareaId)
		{
			var requestPath = this.ApiPathDict["mapcell"];
			var extraQuery = string.Format("api_mapinfo_no={0}&api_maparea_id={1}", mapinfoId, mapareaId);
			return await KcsHttpRequest<MapCellData>(requestPath, extraQuery);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="formation"></param>
		/// <param name="deckId"></param>
		/// <param name="mapinfoId"></param>
		/// <param name="mapareaId"></param>
		/// <returns></returns>
		public async Task<StartData> LoadStart(int formation,int deckId,int mapinfoId,int mapareaId)
		{
			var requestPath = this.ApiPathDict["start"];
			var extraQuery = string.Format("api_formation_id={0}&api_deck_id={1}&api_mapinfo_no={2}&api_maparea_id={3}",
				formation, deckId, mapinfoId, mapareaId);
			return await KcsHttpRequest<StartData>(requestPath, extraQuery);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="formation"></param>
		/// <returns></returns>
		public async Task<BattleData> LoadBattle(int formation)
		{
			var requestPath = this.ApiPathDict["battle"];
			var extraQuery = string.Format("api_formation={0}",
				formation);
			return await KcsHttpRequest<BattleData>(requestPath, extraQuery);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public async Task<BattleResultData> LoadBattleResult()
		{
			var requestPath = this.ApiPathDict["battleresult"];
			var extraQuery = "";
			return await KcsHttpRequest<BattleResultData>(requestPath, extraQuery);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public async Task<SlotItemData> LoadSlotItem()
		{
			var requestPath = this.ApiPathDict["slotitem"];
			var extraQuery = "";
			return await KcsHttpRequest<SlotItemData>(requestPath, extraQuery);
		}

		/// <summary>
		/// プレイヤーが所有する艦船リストを取得するAPIを呼び出します
		/// </summary>
		/// <returns></returns>
		public async Task<Ship2Data> LoadShip2()
		{
			// リクエストパラメータは固定で使用しています。

			var requestPath = this.ApiPathDict["ship2"];
			var extraQuery = "api_sort_order=2&api_sort_key=1";
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
				custom = custom.Replace("_", "%5F");
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
