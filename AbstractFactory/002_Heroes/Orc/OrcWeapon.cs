using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Heroes.Orc
{
	class OrcWeapon : IWeapon
	{
		public double Damage => 10;

		public double Sharpness => 0.8;

		public string Name => "Оружие орка";

		public double Weight => 10;
	}
}
