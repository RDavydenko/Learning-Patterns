using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite._001_Packets_and_things
{
	/// <summary>
	/// Интерфейс предмета
	/// </summary>
	public interface IThing
	{
		/// <summary>
		/// Вернуть стоимость
		/// </summary>
		/// <returns>Стоимость</returns>
		decimal GetCost();

		/// <summary>
		/// Вернуть вес
		/// </summary>
		/// <returns>Вес</returns>
		double GetWeight();
	}
}
