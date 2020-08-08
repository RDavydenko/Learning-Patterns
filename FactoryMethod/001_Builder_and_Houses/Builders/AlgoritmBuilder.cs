using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod._001_Builder_and_Houses.Houses;

namespace FactoryMethod._001_Builder_and_Houses.Builders
{
	/// <summary>
	/// Застройщик "Алгоритм"
	/// </summary>
	public class AlgoritmBuilder : IBuilder
	{
		public IHouse Build()
		{
			return new BrickHouse(50000000, 480, 4800, 10);
		}
	}
}
