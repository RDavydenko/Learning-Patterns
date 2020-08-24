using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using State._001_WaterStates.States;

namespace State._001_WaterStates
{
	/// <summary>
	/// Вода
	/// </summary>
	public class Water
	{
		/// <summary>
		/// Текущее состояние воды
		/// </summary>
		public WaterState State { get; set; }

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="state">Текущее состояние воды</param>
		public Water(WaterState state)
		{
			State = state ?? throw new ArgumentNullException(nameof(state));
		}
		
		/// <summary>
		/// Охладить
		/// </summary>
		public void Cool()
		{
			State.Cool(this);
		}

		/// <summary>
		/// Нагреть
		/// </summary>
		public void Heat()
		{
			State.Heat(this);
		}

		public override string ToString()
		{
			return State.ToString();
		}
	}
}
