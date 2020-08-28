using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prototype._001;

namespace Prototype
{
	class Program
	{
		static void Main(string[] args)
		{
			// Создаем оригинальный объект
			var car = new Car() { MaxSpeed = 180, Oil = 60 };

			// Выполняем клонирование объекта
			var clon = car.Clone() as Car;

			// Изменяем оригинальный
			car.Oil = 0;

			// Выводим на экран данные об обеих машинах
			Console.WriteLine($"Оригинальная: Скорость {car.MaxSpeed}. Топливо {car.Oil}");
			Console.WriteLine($"Копия: Скорость {clon.MaxSpeed}. Топливо {clon.Oil}");
		}
	}
}
