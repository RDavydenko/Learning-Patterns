using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Iterator._001;

namespace Iterator
{
	class Program
	{
		static void Main(string[] args)
		{
			IteratorTest(); // 001
		}

		/// <summary>
		/// Тестируем первый пример реализации паттерна Итератор (Iterator)
		/// </summary>
		private static void IteratorTest()
		{
			// Коллекция слов
			WordsCollection words = new WordsCollection() {
				"Alpha", "Ball", "Cancel"
			};

			// Выводим слова с помощью итератора в прямом порядке
			Console.WriteLine("Прямой порядок слов:");
			foreach (var word in words)
			{
				Console.WriteLine(word);
			}

			// Выводим слова с помощью итератора в обратном порядке
			words.Reversed = true; // Устанавливаем обратный порядок
			Console.WriteLine("\nОбратный порядок слов:");
			foreach (var word in words)
			{
				Console.WriteLine(word);
			}
		}
	}
}
