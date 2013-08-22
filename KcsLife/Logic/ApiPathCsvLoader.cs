using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Logic
{
	public class ApiPathCsvLoader
	{
		public Dictionary<string, string> Load()
		{
			var dict = new Dictionary<string, string>();

			using (var sr = new StreamReader("apipath.csv", Encoding.GetEncoding("shift_jis")))
			using (var csv = new CsvReader(sr, false, ','))
			{
				while (csv.ReadNextRecord())
				{
					var apiname = csv[0];
					var path = csv[1];

					dict.Add(apiname, path);
				}
			}

			return dict;
		}
	}
}
