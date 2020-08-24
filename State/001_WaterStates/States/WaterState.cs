using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State._001_WaterStates.States
{
	/// <summary>
	/// Абстрактный класс состояния воды
	/// </summary>
	public abstract class WaterState
	{		
		/// <summary>
		/// Охладить
		/// </summary>
		/// <param name="water">Вода</param>
		public abstract void Cool(Water water);

		/// <summary>
		/// Нагреть
		/// </summary>
		/// <param name="water">Вода</param>
		public abstract void Heat(Water water);
	}
}
