using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod._001_Builder_and_Houses.Houses
{
	/// <summary>
	/// Панельный дом
	/// </summary>
	public class PanelHouse : HouseBase
	{
		public PanelHouse(decimal cost, int capacity, double square, int floors)
			: base(cost, capacity, square, floors)
		{

		}
	}
}
