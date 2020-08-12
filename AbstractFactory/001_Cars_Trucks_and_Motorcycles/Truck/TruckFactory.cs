using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Trucks_and_Motorcycles.Truck
{
	/// <summary>
	/// Фабрика грузового автомобиля
	/// </summary>
	public class TruckFactory : IAutoFactory
	{
		public IBody CreateBody()
		{
			return new TruckBody();
		}

		public IEngine CreateEngine()
		{
			return new TruckEngine();
		}

		public ITank CreateTank()
		{
			return new TruckTank();
		}
	}
}
