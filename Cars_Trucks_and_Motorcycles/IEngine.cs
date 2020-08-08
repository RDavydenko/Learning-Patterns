using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Trucks_and_Motorcycles
{
	/// <summary>
	/// Интерфейс двигателя
	/// </summary>
	public interface IEngine : IComponent
	{
		/// <summary>
		/// Максимальная скорость, достигаемая двигателем
		/// </summary>
		double MaxSpeed { get; }

		/// <summary>
		/// Расход топлива на 100км при движении с определенной скоростью
		/// 
		/// </summary>
		/// <param name="speed">Скорость движения</param>
		/// <returns>Объем топлива (л.)</returns>
		double GetConsumption(double speed);
	}
}
