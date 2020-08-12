using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator._001_PC_Builder;
using Decorator._001_PC_Builder.Decorators;
using Decorator._002_Worker;
using Decorator._002_Worker.Decorator;

namespace Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			ComputerComponentDecoratorTest(); // 001
			Console.WriteLine();

			WorkerDecoratorTest(); // 002
			Console.WriteLine();
		}
		
		/// <summary>
		/// Тестируем первый пример паттерна Декоратор (компоненты ПК)
		/// </summary>
		private static void ComputerComponentDecoratorTest()
		{
			ComputerBase pc = new SimpleComputer(); // Создали обычный компьютер (базовая стоимость 5000)
			pc = new ProcessorComponent(pc, "Intel Xeon X5650", 1600); // Добавили процессор
			pc = new GraphicCardComponent(pc, "Nvidia GTX 1060 6Gb", 20000); // Добавили видеокарту
			pc = new DramComponent(pc, "Kingston DDR3 16Gb", 4000); // Добавили ОЗУ

			Console.WriteLine($"Стоимость: {pc.GetCost()}. Комплектующие: {pc.GetComponentsDescription()}");
		}

		/// <summary>
		/// Тестируем второй пример паттерна Декоратор (добавление функциональности в класс <see cref="Worker"/>)
		/// </summary>
		private static void WorkerDecoratorTest()
		{
			Worker worker = new Worker();
			worker = new LoggingWorker(worker); // Декорируем класс, добавляя логирование
			worker = new SendingWorker(worker); // Декорируем класс, добавляя отправку сообщений на почту
			worker.DoSomeWork("Бла бла");
		}
	}
}
