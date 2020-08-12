using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Heroes.General
{
	class MobInventory : IInventory
	{
		public int Capacity => 0;

		public int Count => 0;

		public string Name => "Инвентарь моба";

		public double Weight => 0;
	}
}
