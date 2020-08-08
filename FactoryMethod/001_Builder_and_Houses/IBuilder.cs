using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod._001_Builder_and_Houses
{
	public interface IBuilder
	{
		/// <summary>
		/// Отстраивает строение типа IHouse
		/// </summary>
		/// <returns></returns>
		IHouse Build();
	}
}
