using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars_Trucks_and_Motorcycles.Car;
using Cars_Trucks_and_Motorcycles.Motorcycle;
using Cars_Trucks_and_Motorcycles.Truck;

namespace Cars_Trucks_and_Motorcycles
{
	class Program
	{
		/// <summary>
		/// Тестирование автомобиля в движении
		/// </summary>
		/// <param name="auto">Автомобиль</param>
		/// <param name="name">Название автомобиля</param>
		/// <returns>Пройденное расстояние</returns>
		static double AutoMove(Auto auto)
		{
			double speed = auto.Engine.MaxSpeed;
			double sum = 0;
			auto.Moved += (sender, distance) =>
			{
				Console.WriteLine($"{auto.Name} проехал {distance:0.0}км. на скорости {speed}км/ч. В бензобаке осталось {auto.Tank.Volume:0.0}л.");
				sum += distance;
			};
			while (auto.Move(speed))
			{
				Task.Delay(500).Wait();
			}
			Console.WriteLine($"Суммарно {auto.Name} проехал {sum:0.0}км.");
			return sum;
		}

		static void Main(string[] args)
		{
			Auto car = new Auto(new CarFactory(), "Легковой автомобиль");
			AutoMove(car);

			Console.WriteLine();

			Auto truck = new Auto(new TruckFactory(), "Грузовой автомобиль");
			AutoMove(truck);

			Console.WriteLine();

			Auto motorcycle = new Auto(new MotorcycleFactory(), "Мотоцикл");
			AutoMove(motorcycle);
		}
	}
}
