using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Heroes
{
	/// <summary>
	/// Представляет собой физический предмет
	/// </summary>
	public interface IItem
	{
		/// <summary>
		/// Название предмета
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Вес предмета
		/// </summary>
		double Weight { get; }
	}
}
