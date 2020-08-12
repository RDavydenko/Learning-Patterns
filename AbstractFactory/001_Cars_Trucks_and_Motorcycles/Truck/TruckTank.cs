using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Trucks_and_Motorcycles.Truck
{
	/// <summary>
	/// Реализация бензобака грузового автомобиля
	/// </summary>
	public class TruckTank : ITank
	{
		public double MaxVolume => 400;

		public double Volume { get; private set; }

		public bool IsEmpty => Volume == 0;

		public double SpeedFactor => 1.0;

		public string Name => "Бензобак грузового автомобиля";

		public double Weight => Volume * 0.8;

		public decimal Price => 20000;

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

		public TruckTank()
		{
			Volume = MaxVolume;
		}
	}
}
