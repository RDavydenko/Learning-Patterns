using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _002_Heroes.Elf;

namespace _002_Heroes
{
	class Program
	{
		static void Main(string[] args)
		{
			var elf1 = new Hero(new ElfFactory(), "Эльф-воин");
			var elf2 = new Hero(new ElfFactory(), "Эльф-лучник");

			elf1.Died += NotifyOfDead;
			elf2.Died += NotifyOfDead;

			while (elf2.Health > 0)
			{
				elf1.Weapon.Atack(elf2);
			}
		}

		/// <summary>
		/// Информирует о смерти персонажа
		/// </summary>		
		static void NotifyOfDead(object target, string name)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"Персонаж {name} умер!");
			Console.ResetColor();
		}
	}
}
