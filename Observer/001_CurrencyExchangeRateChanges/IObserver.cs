using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer._001_CurrencyExchangeRateChanges
{
	/// <summary>
	/// Интерфейс наблюдателя (подписчика)
	/// </summary>
	public interface IObserver
	{
		/// <summary>
		/// Обновление (при уведомлении)
		/// </summary>
		/// <param name="currency">Наименование валюты</param>
		/// <param name="rate">Текущий курс</param>
		void Update(string currency, double rate);
	}
}
