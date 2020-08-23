using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.BuildingMachines
{
	/// <summary>
	/// Собрщик грузового автомобиля
	/// </summary>
	public class TruckBuilder : TransportBuilderBase
	{
		public override void BuildCase()
		{
			Console.WriteLine("Собрали кузов с прицепом для грузового автомобиля");
		}

		public override void BuildChassis()
		{
			Console.WriteLine("Собрали 8 колес для грузового автомобиля");
		}

		public override void BuildEngine()
		{
			Console.WriteLine("Собрали мощный двигатель на 400 л.с. для грузового автомобиля");
		}
	}
}
