using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder._001_BreadBuilder
{
	/// <summary>
	/// Испеченный хлеб
	/// </summary>
	public class Bread
	{
		/// <summary>
		/// Соль
		/// </summary>
		public double Salt { get; set; }
		/// <summary>
		/// Вид муки
		/// </summary>
		public FlourType FlourType { get; set; }
		/// <summary>
		/// Мука
		/// </summary>
		public double Flour { get; set; }
		/// <summary>
		/// Масло
		/// </summary>
		public double Butter { get; set; }
		/// <summary>
		/// Специи
		/// </summary>
		public string[] Spices { get; set; }

		public override string ToString()
		{
			string flourType = FlourType == FlourType.Rye ? "Ржаная" : FlourType == FlourType.Wheat ? "Пшеничная" : string.Empty;
			string aboutSpices = Spices.Length != 0 ? string.Join(", ", Spices) : "Нет";
			return $"Мука: {flourType}. Кол-во муки: {Flour:0.00}. Соль: {Salt:0.00}. Масло: {Butter:0.00}. Специи: {aboutSpices}";
		}
	}
}
