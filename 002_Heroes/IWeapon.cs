using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Heroes
{
	/// <summary>
	/// Представляет собой оружие
	/// </summary>
	public interface IWeapon : IItem
	{
		/// <summary>
		/// Базовый урон
		/// </summary>
		double Damage { get; }

		/// <summary>
		/// Острота (множитель урона)
		/// </summary>
		double Sharpness { get; }

		/// <summary>
		/// Нанести атаку по цели
		/// </summary>
		/// <param name="target">Атакуемая цель</param>		
		void Atack(ITarget target);
	}
}
