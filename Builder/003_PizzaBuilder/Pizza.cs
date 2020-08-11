using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder._003_PizzaBuilder
{
	/// <summary>
	/// Пицца
	/// </summary>
	public class Pizza
	{
		/// <summary>
		/// Диаметр
		/// </summary>
		public int Diameter { get; set; }

		/// <summary>
		/// Количество порций
		/// </summary>
		public int PortionsCount { get; set; }

		/// <summary>
		/// Имеет ли сыр?
		/// </summary>
		public bool HasCheese { get; set; }

		public override string ToString()
		{
			string hasCheese = HasCheese == true ? "с сыром" : "без сыра";
			return $"Пицца {hasCheese}, диаметр: {Diameter}, количество порций: {PortionsCount}";
		}
	}
}
