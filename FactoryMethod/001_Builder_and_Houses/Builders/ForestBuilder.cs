using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod._001_Builder_and_Houses.Houses;

namespace FactoryMethod._001_Builder_and_Houses.Builders
{
	/// <summary>
	/// Лесной застройщик (может быть лесник подрабатывает)
	/// </summary>
	public class ForestBuilder : IBuilder
	{
		public IHouse Build()
		{
			return new WoodenHouse(1000000, 4, 70, 1);
		}
	}
}
