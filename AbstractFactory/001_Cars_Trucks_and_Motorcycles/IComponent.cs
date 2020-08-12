using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Trucks_and_Motorcycles
{
	/// <summary>
	/// Определяет базовые свойства компонента
	/// </summary>
	public interface IComponent
	{
		/// <summary>
		/// Название компонента
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Вес компонента
		/// </summary>
		double Weight { get; }

		/// <summary>
		/// Цена компонента
		/// </summary>
		decimal Price { get; }
	}
}
