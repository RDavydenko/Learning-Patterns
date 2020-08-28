using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mediator._001_Conceptual.Mediators;

namespace Mediator._001_Conceptual.Components
{
	/// <summary>
	/// Базовый класс компонента
	/// </summary>
	public abstract class ComponentBase 
	{
		/// <summary>
		/// Посредник
		/// </summary>
		protected IMediator _mediator;

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="mediator">Посредник</param>
		public ComponentBase(IMediator mediator = null)
		{
			_mediator = mediator;
		}

		/// <summary>
		/// Установить посредника
		/// </summary>
		/// <param name="mediator">Посредник</param>
		public void SetMediator(IMediator mediator)
		{
			_mediator = mediator;
		}
	}
}
