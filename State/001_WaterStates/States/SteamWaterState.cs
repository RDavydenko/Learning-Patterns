using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State._001_WaterStates.States
{
	/// <summary>
	/// Состояние газообразной воды (пара)
	/// </summary>
	public class SteamWaterState : WaterState
	{
		public override void Cool(Water water)
		{
			water.State = new LiquidWaterState();
			Console.WriteLine("Вода перешла в жидкое состояние");
		}

		public override void Heat(Water water)
		{
			Console.WriteLine("Вода уже находится в газообразном состоянии");
		}

		public override string ToString()
		{
			return "Газообразное состояние";
		}
	}
}
