using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod._001_Builder_and_Houses.Houses
{
	/// <summary>
	/// Кирпичный дом
	/// </summary>
	public class BrickHouse : HouseBase
	{
		public BrickHouse(decimal cost, int capacity, double square, int floors)
			: base(cost, capacity, square, floors)
		{

		}
	}
}
