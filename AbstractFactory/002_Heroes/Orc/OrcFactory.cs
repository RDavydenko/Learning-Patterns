using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _002_Heroes.General;

namespace _002_Heroes.Orc
{
	public class OrcFactory : IHeroFactory
	{
		public IArmor CreateArmor()
		{
			return new OrcArmor();
		}

		public IInventory CreateInventory()
		{
			return new MobInventory();
		}

		public IWeapon CreateWeapon()
		{
			return new OrcWeapon();
		}
	}
}
