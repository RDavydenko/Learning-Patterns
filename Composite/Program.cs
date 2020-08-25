using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Composite._001_Packets_and_things;
using Composite._002_Composite_Builder;

namespace Composite
{
	class Program
	{
		static void Main(string[] args)
		{
			PacketAndThingsTest(); // 001
			Console.WriteLine();

			Console.WriteLine("***************************************************");

			CompositePlusBuilderTest(); // 002
			Console.WriteLine();
		}
		
		/// <summary>
		/// Тестируем первый пример реализации паттерна Компоновщик
		/// </summary>
		private static void PacketAndThingsTest()
		{
			// Разные виды упаковок
			var suitcase = new Packet("Чемодан", 4000, 2);
			var packet = new Packet("Пакет", 5, 0.02);
			var foodCase = new Packet("Кейс для еды", 150, 0.1);

			// Вещи
			var books = new Thing("Книги", 1000, 5);
			var teapot = new Thing("Чайник", 500, 2);
			var sneakers = new Thing("Кросcовки", 4000, 1);
			var hamburger = new Thing("Гамбургер", 50, 0.2);

			// Упаковываем
			foodCase.AddComponent(hamburger);
			packet.AddComponent(sneakers);
			suitcase.AddComponent(books);
			suitcase.AddComponent(teapot);
			suitcase.AddComponent(packet);
			suitcase.AddComponent(foodCase);
			/* В чемодане книги, чайник, пакет с кроссовками, кейс для еды с гамбургером */

			// Считаем общую стоимость и вес
			var allCost = suitcase.GetCost(); // Стоимость всех вложенных вещей
			Console.WriteLine();
			var allWeight = suitcase.GetWeight(); // Вес всех вложенных вещей
			Console.WriteLine($"Общая стоимость: {allCost:0.0}р. Общий вес: {allWeight:0.000}кг.");
		}


		/// <summary>
		/// Тестируем усовершенствованный пример Компоновщика (Composite) в паре со Строителем (Builder) <see cref="ThingBuilder"/>.
		/// </summary>
		private static void CompositePlusBuilderTest()
		{
			// Создаем строителя и настраиваем конфигурацию дерева Компоновщика
			ThingBuilder tb = new ThingBuilder("Чемодан", 4000, 2)
				.AddThing("Книги", 1000, 5)
				.AddThing("Чайник", 500, 2)
				.AddPacket("Пакет", 5, 0.02)
				.AddPacket("Кейс для еды", 150, 0.1)

				.SetCurrentPacket("Пакет")
				.AddThing("Кроссовки", 4000, 1)

				.SetCurrentPacket("Кейс для еды")
				.AddThing("Гамбургер", 50, 0.2);

			Packet suitcase = tb.Build(); // Чемодан (корневая упаковка билдера)
			var allCost = suitcase.GetCost(); // Стоимость всех вложенных вещей
			Console.WriteLine();
			var allWeight = suitcase.GetWeight(); // Вес всех вложенных вещей
			Console.WriteLine($"Общая стоимость: {allCost:0.0}р. Общий вес: {allWeight:0.000}кг.");
		}
	}
}
