using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Logic
{
	public class ShipCsvLoader
	{
		/// <summary>
		/// 艦IDと艦の名称の対応表をファイルから読み込みます
		/// </summary>
		/// <returns></returns>
		public Dictionary<int, string> Load()
		{
			var dict = new Dictionary<int, string>();

			using (var sr = new StreamReader("kcs_ships.csv", Encoding.GetEncoding("shift_jis")))
			using (var csv = new CsvReader(sr, false, ','))
			{
				while (csv.ReadNextRecord())
				{
					var id = Int32.Parse(csv[0]);
					var shipname = csv[1];

					dict.Add(id, shipname);
				}
			}

			return dict;
		}
	}
}
