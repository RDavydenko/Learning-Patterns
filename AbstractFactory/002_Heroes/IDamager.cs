using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Heroes
{
	/// <summary>
	/// Представляет персонажа, способного атаковать
	/// </summary>
	public interface IDamager : INamed
	{
		/// <summary>
		/// Нанести атаку по цели
		/// </summary>
		/// <param name="target">Атакуемая цель</param>		
		void Atack(ITarget target);
	}
}
