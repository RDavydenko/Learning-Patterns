using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _002_Heroes;
using _002_Heroes.Elf;
using _002_Heroes.Orc;
using Cars_Trucks_and_Motorcycles;
using Cars_Trucks_and_Motorcycles.Car;
using Cars_Trucks_and_Motorcycles.Motorcycle;
using Cars_Trucks_and_Motorcycles.Truck;

namespace AbstractFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			AutoFactoriesTest(); // 001
			Console.WriteLine();

			HeroFactoriesTest(200); // 002
			Console.WriteLine();
		}

		/// <summary>
		/// Тестируем первый пример реализации паттерна Абстрактная Фабрика на примере фабрики автомобилей
		/// </summary>
		static void AutoFactoriesTest()
		{

			Auto car = new Auto(new CarFactory(), "Легковой автомобиль");
			AutoMove(car, 100);

			Console.WriteLine();

			Auto truck = new Auto(new TruckFactory(), "Грузовой автомобиль");
			AutoMove(truck, 100);

			Console.WriteLine();

			Auto motorcycle = new Auto(new MotorcycleFactory(), "Мотоцикл");
			AutoMove(motorcycle, 100);
		}

		/// <summary>
		/// Тестируем второй пример реализации паттерна Абстрактная Фабрика на примере фабрики персонажей
		/// </summary>
		/// <param name="delayMiliseconds">Задержка в миллисекундах между действиями персонажа</param>
		static void HeroFactoriesTest(int delayMiliseconds)
		{
			var elf1 = new Hero(new ElfFactory(), "Эльф-воин");
			var elf2 = new Hero(new ElfFactory(), "Эльф-лучник");
			var orc1 = new Hero(new OrcFactory(), "Орк-воин");
			var orc2 = new Hero(new OrcFactory(), "Орк-лучник");
			var heroes = new List<Hero>() { elf1, elf2, orc1, orc2 };

			foreach (var hero in heroes)
			{
				hero.Died += NotifyOfDead;
				hero.Attacked += NotifyOfAttacked;
				hero.DidDamage += NotifyOfDidDamage;
				hero.TookDamage += NotifyOfTookDamage;
				hero.ReflectedDamage += NotifyOfReflectDamage;
			}

			while (elf2.Health > 0)
			{
				orc1.Atack(elf2);
				Task.Delay(delayMiliseconds).Wait();
			}
		}

		/// <summary>
		/// Информирует о смерти персонажа
		/// </summary>		
		private static void NotifyOfDead(ITarget target)
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine($"Персонаж {target.Name} умер!");
			Console.ResetColor();
		}

		/// <summary>
		/// Информирует о том, что персонаж атаковал другого персонажа
		/// </summary>		
		private static void NotifyOfAttacked(IDamager damager, ITarget target)
		{
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine($"Персонаж {damager.Name} атаковал персонажа {target.Name}!");
			Console.ResetColor();
		}

		/// <summary>
		/// Информирует о нанесении урона другому персонажу
		/// </summary>		
		private static void NotifyOfDidDamage(IDamager damager, ITarget target, double damage)
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine($"Персонаж {damager.Name} нанес {damage:0.0} урона персонажу {target.Name}");
			Console.ResetColor();
		}

		/// <summary>
		/// Информирует о получении урона от другого персонажа
		/// </summary>	
		private static void NotifyOfTookDamage(ITarget target, IDamager damager, double damage)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine($"Персонаж {target.Name} получил {damage:0.0} урона от персонажа {damager.Name}");
			Console.ResetColor();
		}

		/// <summary>
		/// Информирует об отражении урона от другого персонажа
		/// </summary>	
		private static void NotifyOfReflectDamage(ITarget target, IDamager damager, double damage)
		{
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine($"Персонаж {target.Name} отразил {damage:0.0} урона от персонажа {damager.Name}");
			Console.ResetColor();
		}

		/// <summary>
		/// Тестирование автомобиля в движении
		/// </summary>
		/// <param name="auto">Автомобиль</param>
		/// <param name="name">Название автомобиля</param>
		/// <returns>Пройденное расстояние</returns>
		static double AutoMove(Auto auto, int delayMilisecond = 500)
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
				Task.Delay(delayMilisecond).Wait();
			}
			Console.WriteLine($"Суммарно {auto.Name} проехал {sum:0.0}км.");
			return sum;
		}
	}
}
