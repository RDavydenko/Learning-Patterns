using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Trucks_and_Motorcycles.Truck
{
	/// <summary>
	/// Реализация корпуса грузового автомобиля
	/// </summary>
	public class TruckBody : IBody
	{
		public double Aerodynamic => 0.8;

		public double MaxWeight => 20000;

		public string Name => "Корпус грузового автомобиля";

		public double Weight => 10000;

		public decimal Price => 4000000;
	}
}
