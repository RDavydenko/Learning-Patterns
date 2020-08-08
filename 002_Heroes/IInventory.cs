using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Heroes
{
	/// <summary>
	/// Представляет инвентарь
	/// </summary>
	public interface IInventory : IItem
	{
		/// <summary>
		/// Вместимость инвентаря
		/// </summary>
		int Capacity { get; }

		/// <summary>
		/// Количество предметов в инвентаре
		/// </summary>
		int Count { get; }
	}
}
