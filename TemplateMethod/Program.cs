using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TemplateMethod.BuildingMachines;

namespace TemplateMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			var carBuilder = new CarBuilder(); // Сборщик легкового автомобиля
			var truckBuilder = new TruckBuilder(); // Сборщик грузового автомобиля
			var tankBuilder = new TankBuilder(); // Сборщик боевого танка

			carBuilder.Build();
			Console.WriteLine();

			truckBuilder.Build();
			Console.WriteLine();

			tankBuilder.Build();
			Console.WriteLine();
		}
	}
}
