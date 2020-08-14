using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer._002_EventOrientedObservers
{
	/// <summary>
	/// Метеостанция 
	/// </summary>
	public class WeatherCenter
	{
		private Random _random = new Random();

		public delegate void WeaterChangedEventHandler(string location, double celcius, string wheatherPattern);

		public event WeaterChangedEventHandler WeatherChanged;

		/// <summary>
		/// Измерить погоду
		/// </summary>
		public void Measure()
		{
			var locations = new string[] { "Москва", "Санкт-Питербург", "Новосибирск", "Волгоград", "Барнаул" };

			// Сезонные погодные явления
			var winterWeatherPatterns = new string[] { "Ясно", "Облачно", "Снег", "Метель" };
			var middleSeasonWeatherPatterns = new string[] { "Ясно", "Облачно", "Дождь", "Ливень", "Град", "Ураган" };
			var summerWeatherPatterns = new string[] { "Ясно", "Облачно", "Дождь", "Ураган" };
			var weatherPatterns = new string[][] { winterWeatherPatterns, middleSeasonWeatherPatterns, summerWeatherPatterns };

			var currentDateTime = DateTime.Now; // Текущее время
			int currentSeason = -1; // Текущий сезон (-1 - не установлено, 0 - зима, 1 - межсезонье, 2 - лето)

			// Определяем сезон
			if (currentDateTime.Month <= 3 || currentDateTime.Month >= 11) // Зимние месяцы (холодные: Ноябрь-Март)
			{
				currentSeason = 0; // Зима
			}
			else if (currentDateTime.Month >= 6 || currentDateTime.Month <= 8) // Летние месяцы (Июнь-Август)
			{
				currentSeason = 2; // Лето
			}
			else
			{
				currentSeason = 1; // Межсезонье
			}

			var newWeatherPattern = weatherPatterns[currentSeason][_random.Next(weatherPatterns[currentSeason].Length)]; // Получаем погодное явление в зависимости от сезона

			// Определяем температуру
			double newTemperatureCelcius = 0; // Температура в цельсиях
			if (currentSeason == 0) // Зима
			{
				newTemperatureCelcius = _random.Next(-40 * 10, -20 * 10) / 10.0;
			}
			else if (currentSeason == 1) // Межсезонье
			{
				newTemperatureCelcius = _random.Next(-15 * 10, 15 * 10) / 10.0;
			}
			else if (currentSeason == 2) // Лето
			{
				newTemperatureCelcius = _random.Next(15 * 10, 40 * 10) / 10.0;
			}

			var location = locations[_random.Next(locations.Length)]; // Локация

			WeatherChanged?.Invoke(location, newTemperatureCelcius, newWeatherPattern); // Инициируем событие "Погода изменилась"
		}
	}
}
