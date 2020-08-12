using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Trucks_and_Motorcycles.Motorcycle
{
	/// <summary>
	/// Реализация корпуса мотоцикла
	/// </summary>
	public class MotorcycleBody : IBody
	{
		public double Aerodynamic => 1.4;

		public double MaxWeight => 400;

		public string Name => "Корпус мотоцикла";

		public double Weight => 40;

		public decimal Price => 20000;
	}
}
