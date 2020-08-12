using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy._002_Mailer.DelivererMaterials
{
	/// <summary>
	/// Интерфейс доставщика информации (получаем данные для расслыки)
	/// </summary>
	public interface IDelivererMaterials
	{
		/// <summary>
		/// Достает свежие данные для рассылки
		/// </summary>
		/// <returns>Материалы</returns>
		string GetMaterials();
	}
}
