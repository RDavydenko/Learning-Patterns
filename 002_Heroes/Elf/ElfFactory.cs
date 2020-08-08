using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _002_Heroes.General;

namespace _002_Heroes.Elf
{
	/// <summary>
	/// Фабрика эльфа-персонажа
	/// </summary>
	public class ElfFactory : IHeroFactory
	{
		public IArmor CreateArmor()
		{
			return new ElfArmor();
		}

		public IInventory CreateInventory()
		{
			return new MobInventory();
		}

		public IWeapon CreateWeapon()
		{
			return new ElfWeapon();
		}
	}
}
