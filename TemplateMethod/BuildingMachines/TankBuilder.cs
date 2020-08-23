using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.BuildingMachines
{
	/// <summary>
	/// Сборщик танка
	/// </summary>
	public class TankBuilder : TransportBuilderBase
	{
		public override void BuildCase()
		{
			Console.WriteLine("Собрали бронированный корпус для танка");
		}

		public override void BuildChassis()
		{
			Console.WriteLine("Собрали гусеницы для танка");
		}

		public override void BuildEngine()
		{
			Console.WriteLine("Собрали двигатель на 1000 л.с. для танка");
		}
	}
}
