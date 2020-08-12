using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy._002_Mailer.DelivererMaterials
{
	public class GeneratorMemes : IDelivererMaterials
	{
		public string GetMaterials()
		{
			// Генерируем новый мем
			return "Мем: когда пытаешься в паттерны 0_о";
		}
	}
}
