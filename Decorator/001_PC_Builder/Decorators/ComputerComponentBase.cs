using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator._001_PC_Builder.Decorators
{
	public abstract class ComputerComponentBase : ComputerBase
	{
		protected ComputerBase Computer { get;  set; }

		public ComputerComponentBase(ComputerBase computerBase) : base()
		{
			Computer = computerBase;
			Cost = Computer.GetCost();
			Components = Computer.Components;
		}
	}
}
