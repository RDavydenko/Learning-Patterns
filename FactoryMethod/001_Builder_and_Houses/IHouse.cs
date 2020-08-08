using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod._001_Builder_and_Houses
{
	public interface IHouse
	{
		/// <summary>
		/// Стоимость
		/// </summary>
		decimal Cost { get; set; }

		/// <summary>
		/// Вместимость
		/// </summary>
		int Capacity { get; set; }

		/// <summary>
		/// Площадь
		/// </summary>
		double Square { get; set; }

		/// <summary>
		/// Этажи 
		/// </summary>
		int Floors { get; set; }
	}
}
