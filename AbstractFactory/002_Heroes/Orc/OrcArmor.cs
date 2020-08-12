using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Heroes.Orc
{
	class OrcArmor : IArmor
	{
		public double ProtectionPoints => 0.3;

		public string Name => "Броня орка";

		public double Weight => 30;

		public double ReflectDamage(double damage)
		{
			if (ProtectionPoints > 1)
			{
				return damage;
			}
			return damage * ProtectionPoints;
		}
	}
}
