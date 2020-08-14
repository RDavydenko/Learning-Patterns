using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer._001_CurrencyExchangeRateChanges;
using Observer._001_CurrencyExchangeRateChanges.Observers;
using Observer._002_EventOrientedObservers;
using Observer._002_EventOrientedObservers.Observers;

namespace Observer
{
	class Program
	{
		static void Main(string[] args)
		{
			CurrencyExchangeRateChangesTest(); // 001
			Console.WriteLine();

			EventOrientedObserversTest(); // 002
			Console.WriteLine();
		}		

		/// <summary>
		/// Тестирует первый пример паттерна Наблюдатель (изменение курса валют)
		/// </summary>
		private static void CurrencyExchangeRateChangesTest()
		{
			// Уведомитель
			var center = new CurrencyCenter();

			// Подписчики
			var mobileBank = new MobileBankApp();
			var graphics = new CurrencyGraphics();
			var bot = new TradingBot();

			// Добавляем подписчиков
			center.AddObserver(mobileBank);
			center.AddObserver(graphics);
			center.AddObserver(bot);

			// Запускаем работу уведомителя
			int i = 0;
			while (i < 10)
			{
				center.ChangeRate();
				Console.WriteLine();
				Task.Delay(1000).Wait();
				i++;
			}
		}

		/// <summary>
		/// Тестирует второй пример паттерна Наблюдатель - обработка событий (event) изменения погоды
		/// </summary>
		private static void EventOrientedObserversTest()
		{
			var gismeteo = new WeatherCenter(); // Метеостанция
			var emercom = new Emercom(); // МЧС
			var widget = new WeatherWidget(); // Погодный виджет

			gismeteo.WeatherChanged += emercom.SendSMS; // Подписываем отправку смс от мчс на событие об изменении погоды
			gismeteo.WeatherChanged += widget.TakeWeatherData; // Подписываем обновление данных в виджете на событие об изменении погоды

			for (int i = 0; i < 10; i++)
			{
				gismeteo.Measure();
				Task.Delay(1000).Wait();
			}
		}
	}
}
