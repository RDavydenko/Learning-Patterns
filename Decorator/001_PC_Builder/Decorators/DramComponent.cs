using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator._001_PC_Builder.Decorators
{
	public class DramComponent : ComputerComponentBase
	{
		public DramComponent(ComputerBase computerBase, string componentName, double componentPrice) : base(computerBase)
		{
			Cost += componentPrice;
			Components.Add(componentName);
		}
	}
}
