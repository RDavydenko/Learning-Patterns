using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Visitor._001.Shapes;
using Visitor._001.Visitors;

namespace Visitor
{
	class Program
	{
		static void Main(string[] args)
		{
			ShapesVisitorTest();
			Console.WriteLine();

			Console.ReadKey();
		}

		/// <summary>
		/// Тестируем первый пример реализации паттерна Посетитель (Visitor)
		/// </summary>
		private static void ShapesVisitorTest()
		{
			// Создаем список фигур, доступных для посещения (реализующих IVisitable)
			var shapes = new List<IVisitable>
			{
				new Dot(),
				new Circle(),
				new Rectangle()
			};

			// Создаем Посетителя (Visitor), реализующего IVisitor
			IVisitor visitor = new _001.Visitors.Visitor();

			// Посещяем все фигуры
			foreach (var shape in shapes)
			{
				shape.Accept(visitor);
			}
		}
	}
}
