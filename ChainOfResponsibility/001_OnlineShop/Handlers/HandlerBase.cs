using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility._001_OnlineShop.Handlers
{
	/// <summary>
	/// Интерфейс обработчика запроса
	/// </summary>
	public abstract class HandlerBase
	{
		/// <summary>
		/// Следующий обработчик
		/// </summary>
		public HandlerBase Next { get; }

		/// <summary>
		/// Констуктор класса
		/// </summary>
		/// <param name="next">Следующий обработчик</param>
		public HandlerBase(HandlerBase next)
		{
			Next = next;
		}

		/// <summary>
		/// Вызвать обработку контекста
		/// </summary>
		/// <param name="context">Контекст</param>
		/// <returns></returns>
		public abstract Task InvokeAsync(Context context);
	}
}
