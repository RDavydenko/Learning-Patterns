using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator._001_PC_Builder.Decorators
{
	public class ProcessorComponent : ComputerComponentBase
	{
		public ProcessorComponent(ComputerBase computerBase, string componentName, double componentPrice) : base(computerBase)
		{
			Cost += componentPrice;
			Components.Add(componentName);
		}		
	}
}
