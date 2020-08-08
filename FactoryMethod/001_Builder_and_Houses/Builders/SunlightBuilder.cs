using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod._001_Builder_and_Houses.Houses;

namespace FactoryMethod._001_Builder_and_Houses.Builders
{
	/// <summary>
	/// Застройщик "Солнечный Луч"
	/// </summary>
	public class SunlightBuilder : IBuilder
	{
		public IHouse Build()
		{
			return new PanelHouse(30000000, 240, 2400, 5);
		}
	}
}
