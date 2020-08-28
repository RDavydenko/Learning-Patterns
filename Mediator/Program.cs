using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mediator._001_Conceptual.Components;
using Mediator._001_Conceptual.Mediators;

namespace Mediator
{
	class Program
	{
		static void Main(string[] args)
		{
			ConceptualMediatorTest(); // 001

			Console.ReadKey();
		}

		/// <summary>
		/// Тестируем первый пример использования паттерна Посредник (Mediator)
		/// </summary>
		private static void ConceptualMediatorTest()
		{
			// Создаем компоненты
			var componentA = new ComponentA();
			var componentB = new ComponentB();

			// Создаем посредника
			IMediator mediator = new ConcreteMediator(componentA, componentB); 

			componentA.DoA(); // Это действие вызовет отправит уведомление Посреднику, а он его обработает
			Console.WriteLine();
			componentB.DoB();
		}
	}
}
