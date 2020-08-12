using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Trucks_and_Motorcycles.Car
{
	/// <summary>
	/// Реализация двигателя легкового автомобиля
	/// </summary>
	public class CarEngine : IEngine
	{
		public double MaxSpeed => 160;

		public string Name => "Двигатель легкового автомобиля";

		public double Weight => 200;

		public decimal Price => 100000;

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
			var expected = (MaxSpeed / (speed + double.Epsilon)) * 8;
			return expected < 20 ? expected : 20;
		}
	}
}
