using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator._001_PC_Builder.Decorators
{
	/// <summary>
	/// Класс, декорирующий базовый класс <see cref="ComputerBase"/>
	/// </summary>
	public class DramComponent : ComputerComponentBase
	{
		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="computerBase">Экземпляр, декорируемого класса</param>
		/// <param name="componentName">Название компонента</param>
		/// <param name="componentPrice">Цена компонента</param>
		public DramComponent(ComputerBase computerBase, string componentName, double componentPrice) : base(computerBase)
		{
			Cost += componentPrice;
			Components.Add(componentName);
		}
	}
}
