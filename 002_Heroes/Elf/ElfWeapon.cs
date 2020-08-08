using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Heroes.Elf
{
	class ElfWeapon : IWeapon
	{
		public double Damage => 5;

		public double Sharpness => 1;

		public string Name => "Оружие эльфа";

		public double Weight => 2;
				
		public void Atack(ITarget target)
		{
			var damage = Damage * Sharpness;
			target.TakeDamage(damage);
		}
	}
}
