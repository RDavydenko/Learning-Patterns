using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State._001_WaterStates.States
{
	/// <summary>
	/// Состояние замороженной воды
	/// </summary>
	public class FrozenWaterState : WaterState
	{
		public override void Cool(Water water)
		{
			Console.WriteLine("Вода уже находится в замороженном состоянии");
		}

		public override void Heat(Water water)
		{
			water.State = new LiquidWaterState();
			Console.WriteLine("Вода перешла в жидкое состояние");
		}

		public override string ToString()
		{
			return "Замороженное состояние";
		}
	}
}
