using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interpreter._001;
using Interpreter._001.Interpteters;

namespace Interpreter
{
	class Program
	{
		static void Main(string[] args)
		{
			InterpreterTest();
		}

		/// <summary>
		/// Тестируем первый пример реализации паттерна Интерпретатор (Interprer)
		/// </summary>
		private static void InterpreterTest()
		{
			// Заполнение контекста
			Context context = new Context();
			context.SetVariable("x", 10); // x = 10
			context.SetVariable("y", 5); // y = 5
			context.SetVariable("z", 2); // z = 2

			// Построение выражения
			// x + y - z - 3 == 10 
			IExpression expression = new SubtractExpression(
			   new SubtractExpression(
				   new AddExpression(
					   new VariableExpression("x"), new VariableExpression("y")),
				   new VariableExpression("z")),
			   new ConstantExpression(3));

			// Получение результата
			int result = expression.Interpret(context);
			Console.WriteLine("Результат выражения: " + result);
		}
	}
}
