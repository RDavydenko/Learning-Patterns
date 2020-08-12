using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Trucks_and_Motorcycles
{
	/// <summary>
	/// Интерфейс бензобака
	/// </summary>
	public interface ITank : IComponent
	{
		/// <summary>
		/// Максимальный объем бензобака (л.)
		/// </summary>
		double MaxVolume { get; }

		/// <summary>
		/// Текущий объем оставшегося топлива (л.)
		/// </summary>
		double Volume { get; }

		/// <summary>
		/// Пустой бак или нет?
		/// </summary>
		bool IsEmpty { get; }

		/// <summary>
		/// Коэффициент эффективности топлива
		/// </summary>
		double SpeedFactor { get; }

		/// <summary>
		/// Потратить определенное количество топлива
		/// </summary>
		/// <param name="fuel">Необходимое количество топлива</param>
		/// <returns>Возвращает реальное количество топливо, которое было потрачено</returns>
		double Spend(double fuel);
	}
}
