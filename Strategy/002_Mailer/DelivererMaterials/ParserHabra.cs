using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy._002_Mailer.DelivererMaterials
{
	/// <summary>
	/// Получает информацию, парсеря статьи Habra
	/// </summary>
	class ParserHabra : IDelivererMaterials
	{
		public string GetMaterials()
		{
			// Парсим статьи
			return "Статья с Хабра";
		}
	}
}
