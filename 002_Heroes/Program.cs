using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _002_Heroes.Elf;
using _002_Heroes.Orc;

namespace _002_Heroes
{
	class Program
	{
		private static void Main(string[] args)
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
	}
}
