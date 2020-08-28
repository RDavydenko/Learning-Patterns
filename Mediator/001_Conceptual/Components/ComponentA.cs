using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mediator._001_Conceptual.Mediators;

namespace Mediator._001_Conceptual.Components
{
	/// <summary>
	/// Конкретный компонент
	/// </summary>
	public class ComponentA : ComponentBase
	{
		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="mediator">Посредник</param>
		public ComponentA(IMediator mediator = null) : base(mediator)
		{
		}

		/// <summary>
		/// Действие A
		/// </summary>
		public void DoA()
		{
			Console.WriteLine("ComponentA did A");
			this._mediator.Notify(this, "A");
		}
	}
}
