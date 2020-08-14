using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer._001_CurrencyExchangeRateChanges.Observers
{
	/// <summary>
	/// Графики валют
	/// </summary>
	public class CurrencyGraphics : IObserver
	{
		/// <summary>
		/// Отрисовывает изменение курса на графиках
		/// </summary>
		/// <param name="currency">Название валюты</param>
		/// <param name="rate">Текущий курс</param>
		private void Draw(string currency, double rate)
		{
			// Логика отрисовки

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"Графики отрисовали обновление валюты {currency}. Текущий курс: {rate:0.00}");
			Console.ResetColor();
		}

		public void Update(string currency, double rate)
		{
			// Перерисовываем графики
			Draw(currency, rate);
		}
	}
}
