using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer._001_CurrencyExchangeRateChanges.Observers
{
	/// <summary>
	/// Бот, торгующий на бирже
	/// </summary>
	public class TradingBot : IObserver
	{
		private Dictionary<string, double> Wallet = new Dictionary<string, double>(); // Кошелек

		private Dictionary<string, double> CurrencyRatePairs = new Dictionary<string, double>(); // Валюты и их текущая стоимость

		public void Update(string currency, double rate)
		{
			if (CurrencyRatePairs.ContainsKey(currency))
			{
				CurrencyRatePairs[currency] = rate;
			}
			else
			{
				CurrencyRatePairs.Add(currency, rate); // Добавляем данные об обновленном курсе
			}

			Analyze();

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"Бот выполнил действия на основе обновленного курса валюты {currency}");
			Console.ResetColor();
		}

		public void Start() { } // Начинает работу

		private void Buy(string currency, double amount) { } // Купить валюту

		private void Send(string currency, double amount) { } // Продать валюту

		private void Analyze() { } // Анализировать рыночную ситуацию
	}
}
