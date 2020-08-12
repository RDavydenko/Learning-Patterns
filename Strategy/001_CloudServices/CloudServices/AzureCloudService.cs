using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy._001_CloudServices.CloudServices
{
	/// <summary>
	/// Представляет собой облачные сервисы Azure
	/// </summary>
	public class AzureCloudService : ICloudService
	{
		/// <summary>
		/// Сохраняет в облачные сервисы Azure
		/// </summary>
		/// <param name="results">Результаты</param>
		public void Save(IList<string> results)
		{
			// Подключение к Azure
			// Передача данных
			Console.WriteLine("Данные успешно загружены в Azure");
		}
	}
}
