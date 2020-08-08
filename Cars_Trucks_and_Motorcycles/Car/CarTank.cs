using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Trucks_and_Motorcycles.Car
{
	/// <summary>
	/// Реализация бензобака легкового автомобиля
	/// </summary>
	public class CarTank : ITank
	{
		public double MaxVolume => 80;

		public double Volume { get; private set; }

		public bool IsEmpty => Volume == 0;

		public double SpeedFactor => 1.2;

		public string Name => "Бензобак легкового автомобиля";

		public double Weight => Volume * 0.8;

		public decimal Price => 4000;

		public double Spend(double fuel)
		{
			if (!IsEmpty)
			{
				double realFuel = fuel * (1 / SpeedFactor); // Уменьшен расход, если качество топлива больше 1
				if (Volume - realFuel < 0)
				{
					var spended = Volume;
					Volume = 0;
					return spended;
				}
				else
				{
					Volume -= realFuel;
					return fuel;
				}
			}
			return 0;
		}

		public CarTank()
		{
			Volume = MaxVolume;
		}
	}
}
