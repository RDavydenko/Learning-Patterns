using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Trucks_and_Motorcycles.Car
{
	/// <summary>
	/// Фабрика легкового автомобиля
	/// </summary>
	public class CarFactory : IAutoFactory
	{		
		public IBody CreateBody()
		{
			return new CarBody();
		}

		public IEngine CreateEngine()
		{
			return new CarEngine();
		}

		public ITank CreateTank()
		{
			return new CarTank();
		}
	}
}
