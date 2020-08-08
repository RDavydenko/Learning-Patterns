﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Heroes
{
	/// <summary>
	/// Представляет собой цель, которую можно атаковать
	/// </summary>
	public interface ITarget
	{
		/// <summary>
		/// Очки здоровья
		/// </summary>
		double Health { get; }

		/// <summary>
		/// Принять урон
		/// </summary>
		/// <param name="damage">Урон</param>
		/// <returns>Принятый урон с учетом брони и др.</returns>
		double TakeDamage(double damage);
	}
}
