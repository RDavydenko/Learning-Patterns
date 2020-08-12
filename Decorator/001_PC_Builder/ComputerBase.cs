using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator._001_PC_Builder
{
	/// <summary>
	/// Базовый класс Компьютера
	/// </summary>
	public abstract class ComputerBase
	{
		/// <summary>
		/// Базовая стоимость компьютера
		/// </summary>
		public double Cost { get; protected set; }

		/// <summary>
		/// Компоненты ПК
		/// </summary>
		public List<string> Components { get; protected set; }

		public ComputerBase()
		{
			Cost = 10000;
			Components = new List<string>();
		}

		/// <summary>
		/// Получить стоимость компьютера
		/// </summary>
		/// <returns>Стоимость ПК</returns>
		public virtual double GetCost()
		{
			return Cost;
		}

		/// <summary>
		/// Получить описание комплектующих
		/// </summary>
		/// <returns>Описание комплектующих</returns>
		public virtual string GetComponentsDescription()
		{
			return string.Join(", ", Components);
		}		
	}
}
