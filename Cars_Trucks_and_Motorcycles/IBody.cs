using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Trucks_and_Motorcycles
{
	/// <summary>
	/// Интерфейс корпуса
	/// </summary>
	public interface IBody : IComponent
	{
		/// <summary>
		/// Коэффициент аэродинамики корпуса
		/// </summary>
		double Aerodynamic { get; }

		/// <summary>
		/// Максимальный допустимый вес всех компонентов
		/// </summary>
		double MaxWeight { get; }
	}
}
