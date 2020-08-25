using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite._001_Packets_and_things
{
	/// <summary>
	/// Вещь
	/// </summary>
	public class Thing : IThing
	{
		/// <summary>
		/// Название
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Стоимость
		/// </summary>
		public decimal Cost { get; }

		/// <summary>
		/// Ввес
		/// </summary>
		public double Weight { get; }
		
		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="name">Название вещи</param>
		/// <param name="cost">Стоимость вещи</param>
		/// <param name="weight">Вес вещи</param>
		public Thing(string name, decimal cost, double weight)
		{
			Name = name;
			Cost = cost;
			Weight = weight;
		}

		public decimal GetCost()
		{
			Console.WriteLine($"Считаем стоимость: {Name}");

			return Cost;
		}

		public double GetWeight()
		{
			Console.WriteLine($"Считаем вес: {Name}");

			return Weight;
		}
	}
}
