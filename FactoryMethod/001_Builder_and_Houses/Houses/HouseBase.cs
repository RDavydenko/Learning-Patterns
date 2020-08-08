using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod._001_Builder_and_Houses.Houses
{
	public abstract class HouseBase : IHouse
	{
		public decimal Cost { get; set; }
		public int Capacity { get; set; }
		public double Square { get; set; }
		public int Floors { get; set; }

		public HouseBase(decimal cost, int capacity, double square, int floors)
		{
			Cost = cost;
			Capacity = capacity;
			Square = square;
			Floors = floors;
		}

		public override string ToString()
		{
			return $"Информация о постройке:\nСтомость: {Cost}\nВместимость: {Capacity}\nПлощадь:{Square}\nКол-во этажей: {Floors}";
		}
	}
}
