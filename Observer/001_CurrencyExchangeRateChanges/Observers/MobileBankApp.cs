using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer._001_CurrencyExchangeRateChanges.Observers
{
	/// <summary>
	/// Мобильное приложение банка
	/// </summary>
	public class MobileBankApp : IObserver
	{
		/// <summary>
		/// Обновляет курс валют 
		/// </summary>
		/// <param name="currency">Валюта</param>
		/// <param name="rate">Курс</param>
		private void ChangeRate(Currency currency, double rate)
		{
			// Какая-то логика по смене курса валюты

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"В мобильном банке произошла смена курса валюты: {currency}. Новый курс: {rate:0.00}");
			Console.ResetColor();
		}

		public void Update(string currency, double rate)
		{
			if (currency == "USD")
			{
				ChangeRate(Currency.USD, rate);
			}
			else if (currency == "EUR")
			{
				ChangeRate(Currency.EUR, rate);
			}
			else if (currency == "CNY")
			{
				ChangeRate(Currency.CNY, rate);
			}
		}

		// Валюты, с которыми может работать этот банк
		private enum Currency
		{
			USD = 0,
			EUR = 1,
			CNY = 2
		}
	}
}
