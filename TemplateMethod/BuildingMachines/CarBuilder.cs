using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.BuildingMachines
{
	/// <summary>
	/// Сборщик легкового автомобиля
	/// </summary>
	public class CarBuilder : TransportBuilderBase
	{
		public override void BuildCase()
		{
			Console.WriteLine("Собрали кузов легкового автомобиля");
		}

		public override void BuildChassis()
		{
			Console.WriteLine("Собрали 4 колеса для легкового автомобиля");
		}

		public override void BuildEngine()
		{
			Console.WriteLine("Собрали двигатель на 100 л.с. для легкового автомобиля");
		}
	}
}
