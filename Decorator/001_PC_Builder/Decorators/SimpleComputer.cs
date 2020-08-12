using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator._001_PC_Builder.Decorators
{
	public class SimpleComputer : ComputerBase
	{
		public SimpleComputer()
		{
			Cost = 5000; // Стоимость сборки и установки комплектующий (базовая стоимость)
		}
	}
}
