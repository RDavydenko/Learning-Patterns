using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Heroes.Elf
{
	class ElfArmor : IArmor
	{
		public double ProtectionPoints => 0.1;

		public string Name => "Эльфийская броня";

		public double Weight => 5;

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
