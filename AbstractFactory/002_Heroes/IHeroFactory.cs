using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Heroes
{
	/// <summary>
	/// Абстрактная фабрика героя
	/// </summary>
	public interface IHeroFactory
	{
		/// <summary>
		/// Создает оружие героя
		/// </summary>
		/// <returns>Оружие</returns>
		IWeapon CreateWeapon();

		/// <summary>
		/// Создает броню героя
		/// </summary>
		/// <returns>Броня</returns>
		IArmor CreateArmor();

		/// <summary>
		/// Создает инвентарь героя
		/// </summary>
		/// <returns>Инвентарь</returns>
		IInventory CreateInventory();
	}
}
