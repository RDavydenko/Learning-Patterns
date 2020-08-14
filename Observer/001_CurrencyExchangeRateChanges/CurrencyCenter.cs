using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer._001_CurrencyExchangeRateChanges
{
	public class CurrencyCenter : ISubject
	{
		private List<IObserver> Observers { get; } = new List<IObserver>();
		private Random _random = new Random();

		public void AddObserver(IObserver observer)
		{
			if (Observers.Contains(observer))
			{
				return;
			}
			Observers.Add(observer);
		}

		public void RemoveObserver(IObserver observer)
		{
			Observers.Remove(observer);
		}

		/// <summary>
		/// Уведомляем подписчиков о смене курса
		/// </summary>
		/// <param name="currency">Название валюты</param>
		/// <param name="rate">Текущий курс</param>
		private void NotifyObservers(string currency, double rate)
		{
			Console.WriteLine("Уведомляем подписчиков...");
			foreach (var observer in Observers)
			{
				observer.Update(currency, rate); // Уведомляем
			}
		}

		/// <summary>
		/// Сменить курс
		/// </summary>
		public void ChangeRate()
		{
			var currencies = new string[] { "USD", "EUR", "CNY", "UAH", "KZT" };
			var lowerLimit = new double[] { 65, 75, 9, 2.5, 0.16 }; // Нижний предел валют
			var upperLimit = new double[] { 78, 88, 10.5, 2.7, 0.175 }; // Верхний предел валют
			int index = _random.Next(currencies.Length); // Валюта, которую будем менять
			double changing = _random.Next((int)((upperLimit[index] - lowerLimit[index]) * 1000.0)) / 1000.0; // Изменение валюты
			double newRate = lowerLimit[index] + changing; // Новый курс

			NotifyObservers(currencies[index], newRate); // Уведомляем подписчиков
		}
	}
}
