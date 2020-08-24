using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State._001_WaterStates.States
{
	/// <summary>
	/// Состояние жидкой воды
	/// </summary>
	public class LiquidWaterState : WaterState
	{
		public override void Cool(Water water)
		{
			water.State = new FrozenWaterState();
			Console.WriteLine("Вода перешла в замороженное состояние");
		}

		public override void Heat(Water water)
		{
			water.State = new SteamWaterState();
			Console.WriteLine("Вода перешла в газообразное состояние");
		}

		public override string ToString()
		{
			return "Жидкое состояние";
		}
	}
}
