using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer._001_CurrencyExchangeRateChanges
{
	/// <summary>
	/// Объект, на который можно подписаться.
	/// Будет уведомлять о событиях подписчиков.
	/// </summary>
	public interface ISubject
	{
		/// <summary>
		/// Добавить наблюдателя (подписчика)
		/// </summary>
		/// <param name="observer">Наблюдатель</param>
		void AddObserver(IObserver observer);


		/// <summary>
		/// Удалить наблюдателя (подписчика)
		/// </summary>
		/// <param name="observer">Наблюдатель</param>
		void RemoveObserver(IObserver observer);
	}
}
