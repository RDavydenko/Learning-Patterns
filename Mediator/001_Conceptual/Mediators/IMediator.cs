using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator._001_Conceptual.Mediators
{
	/// <summary>
	/// Интерфейс посредника
	/// </summary>
	public interface IMediator
	{
		/// <summary>
		/// Уведомляет посредника о произошедшем событии на компоненте
		/// </summary>
		/// <param name="sender">Отправитель (компонент)</param>
		/// <param name="event">Событие</param>
		void Notify(object sender, string @event);
	}
}
