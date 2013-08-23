using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KcsLife.Constant
{
	/// <summary>
	/// 艦船の固定情報
	/// </summary>
	public class ShipStaticData
	{
		/// <summary>
		/// 艦船名
		/// </summary>
		public string ShipName { get; set; }

		/// <summary>
		/// ex. 駆逐艦
		/// </summary>
		public string ShipType { get; set; }

		/// <summary>
		/// 火力
		/// </summary>
		public int Karyoku { get; set; }

		/// <summary>
		/// 雷装
		/// </summary>
		public int Raisou { get; set; }

		/// <summary>
		/// 対空
		/// </summary>
		public int Taikuu { get; set; }

		/// <summary>
		/// 対潜
		/// </summary>
		public int Taisen { get; set; }

		/// <summary>
		/// 索敵
		/// </summary>
		public int Sakuteki { get; set; }

		/// <summary>
		/// 運
		/// </summary>
		public int Luck { get; set; }

		/// <summary>
		/// 耐久
		/// </summary>
		public int Taikyuu { get; set; }

		/// <summary>
		/// 装甲
		/// </summary>
		public int Soukou { get; set; }

		/// <summary>
		/// 回避
		/// </summary>
		public int Kaihi { get; set; }

		/// <summary>
		/// 燃料最大
		/// </summary>
		public int Fuel { get; set; }

		/// <summary>
		/// 弾数最大
		/// </summary>
		public int Bull { get; set; }
	}
}
