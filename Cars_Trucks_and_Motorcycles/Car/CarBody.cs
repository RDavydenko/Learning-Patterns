using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Trucks_and_Motorcycles.Car
{
	/// <summary>
	/// Реализация корпуса легкового автомобиля
	/// </summary>
	public class CarBody : IBody
	{
		public double Aerodynamic => 1.3;

		public double MaxWeight => 2000;

		public string Name => "Корпус легкового автомобиля";

		public double Weight => 600;

		public decimal Price => 100000;
	}
}
