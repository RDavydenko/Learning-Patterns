using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Trucks_and_Motorcycles
{
	/// <summary>
	/// Интерфейс абстрактной фабрики автомобилей
	/// </summary>
	public interface IAutoFactory
	{
		/// <summary>
		/// Создает двигатель автомобиля
		/// </summary>
		/// <returns>Двигатель автомобиля</returns>
		IEngine CreateEngine();

		/// <summary>
		/// Создает корпус автомобиля
		/// </summary>
		/// <returns>Корпус автомобиля</returns>
		IBody CreateBody();

		/// <summary>
		/// Создает бензобак автомобиля
		/// </summary>
		/// <returns>Бензобак автомобиля</returns>
		ITank CreateTank();
	}
}
