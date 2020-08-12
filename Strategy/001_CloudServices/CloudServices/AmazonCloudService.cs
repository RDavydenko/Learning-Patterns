using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy._001_CloudServices.CloudServices
{
	/// <summary>
	/// Представляет собой облачные сервисы Амазона
	/// </summary>
	public class AmazonCloudService : ICloudService
	{
		/// <summary>
		/// Сохраняет в облачные сервисы Амазона
		/// </summary>
		/// <param name="results">Результаты</param>
		public void Save(IList<string> results)
		{
			// Подключение к Амазону
			// Передача данных
			Console.WriteLine("Данные успешно загружены в Amazon");
		}
	}
}
