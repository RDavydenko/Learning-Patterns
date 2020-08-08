using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Heroes
{
	/// <summary>
	/// Представляет собой броню
	/// </summary>
	public interface IArmor : IItem
	{
		/// <summary>
		/// Очки защиты
		/// </summary>
		double ProtectionPoints { get; }

		/// <summary>
		/// Отражает урон с учетом брони
		/// </summary>
		/// <returns>Количество отраженного урона</returns>
		double ReflectDamage(double damage);
	}
}
