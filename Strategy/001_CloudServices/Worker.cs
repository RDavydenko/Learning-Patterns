using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy._001_CloudServices.CloudServices;

namespace Strategy._001_CloudServices
{
	/// <summary>
	/// Позволяет осуществлять некую работу, необходимую заказчику и сохранять результат в облако
	/// </summary>
	public class Worker
	{
		/// <summary>
		/// Представляет собой облачный сервис
		/// </summary>
		private readonly ICloudService _cloudBehavior;

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="cloudBehavior"></param>
		public Worker(ICloudService cloudBehavior)
		{
			_cloudBehavior = cloudBehavior;
		}

		/// <summary>
		/// Делает некую работу и сохраняет ее результат
		/// </summary>
		public async Task DoWork()
		{
			List<string> results = new List<string>(); // Сюда будут записаны результаты работы
			await Task.Delay(1000); // Происходит какая-то работа
			results.Add("Данные");

			Save(results); // Сохраняем результаты на выбранный облачный сервис
		}

		/// <summary>
		/// Сохраняет результаты работы в облако
		/// </summary>
		/// <param name="results">Результаты работы</param>
		private void Save(List<string> results)
		{
			_cloudBehavior.Save(results); // Сохранение
		}
	}
}
