using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator._001_PC_Builder.Decorators
{
	/// <summary>
	/// Класс-декоратор для класса <see cref="ComputerBase"/>
	/// </summary>
	public abstract class ComputerComponentBase : ComputerBase
	{
		/// <summary>
		/// Декорируемый экземляр класса
		/// </summary>
		protected ComputerBase Computer { get;  set; }

		public ComputerComponentBase(ComputerBase computerBase) : base()
		{
			Computer = computerBase;
			Cost = Computer.GetCost();
			Components = Computer.Components;
		}
	}
}
