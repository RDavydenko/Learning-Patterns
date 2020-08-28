using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mediator._001_Conceptual.Components;

namespace Mediator._001_Conceptual.Mediators
{
	/// <summary>
	/// Конкретная реализация интерфейса <see cref="IMediator"/>
	/// </summary>
	public class ConcreteMediator : IMediator
	{
		private ComponentA _componentA;
		private ComponentB _componentB;

		public ConcreteMediator(ComponentA componentA, ComponentB componentB)
		{
			_componentA = componentA;
			_componentA.SetMediator(this);
			_componentB = componentB;
			_componentB.SetMediator(this);
		}

		public void Notify(object sender, string @event)
		{
			if (@event == "A") // Реагируем на уведомление A
			{
				Console.WriteLine("Mediator react on A and call componentB.DoB()");
				_componentB.DoB();
			}
			else if (@event == "B") // Реагируем на уведомление B
			{
				Console.WriteLine("Mediator react on B and do nothing");
			}
		}
	}
}
