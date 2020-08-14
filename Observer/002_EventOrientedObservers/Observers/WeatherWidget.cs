using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer._002_EventOrientedObservers.Observers
{
	// Виджет, отображающий погоду
	public class WeatherWidget
	{
		/// <summary>
		/// Принимает погодные данные
		/// </summary>
		/// <param name="location">Локация</param>
		/// <param name="celcius">Градусы в цельсиях</param>
		/// <param name="weatherPattern">Погодное явление</param>
		public void TakeWeatherData(string location, double celcius, string weatherPattern)
		{
			// Проверяем пришедшие данные на валидность
			bool isDataValid = true;

			if (isDataValid)
			{
				UpdateWeatherData(location, celcius, weatherPattern);
			}
		}

		/// <summary>
		/// Обновляет данные в виджете
		/// </summary>
		/// <param name="location">Локация</param>
		/// <param name="celcius">Градусы в цельсиях</param>
		/// <param name="weatherPattern">Погодное явление</param>
		private void UpdateWeatherData(string location, double celcius, string weatherPattern)
		{
			// Логика обновления данных

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"Виджет обновил информацию: Город: {location}. Температура: {celcius:0.0}. Погодное явление: {weatherPattern}");
			Console.ResetColor();
		}
	}
}
