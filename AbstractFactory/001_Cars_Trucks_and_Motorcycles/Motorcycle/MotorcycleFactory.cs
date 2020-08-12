using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Trucks_and_Motorcycles.Motorcycle
{
	/// <summary>
	/// Реализация фабрики мотоцикла
	/// </summary>
	public class MotorcycleFactory : IAutoFactory
	{
		public IBody CreateBody()
		{
			return new MotorcycleBody();
		}

		public IEngine CreateEngine()
		{
			return new MotorcycleEngine();
		}

		public ITank CreateTank()
		{
			return new MotorcycleTank();
		}
	}
}
