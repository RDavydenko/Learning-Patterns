using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Trucks_and_Motorcycles.Truck
{
	/// <summary>
	/// Реализация двигателя грузового автомобиля
	/// </summary>
	public class TruckEngine : IEngine
	{
		public double MaxSpeed => 80;

		public string Name => "Двигатель грузового автомобиля";

		public double Weight => 2000;

		public decimal Price => 1000000;

		/// <summary>
		/// Расход топлива на 100км при движении с определенной скоростью.
		/// Выбрасывает <see cref="Exception"/>, если скорость движения больше максимально возможной
		/// </summary>
		/// <param name="speed">Скорость движения</param>
		/// <returns>Объем топлива (л.)</returns>
		public double GetConsumption(double speed)
		{
			if (speed > MaxSpeed)
			{
				throw new Exception("Скорость движения не может быть выше масимальной заданной скорости движения");
			}
			var expected = (MaxSpeed / (speed + double.Epsilon)) * 14;
			return expected < 30 ? expected : 30;
		}
	}
}
