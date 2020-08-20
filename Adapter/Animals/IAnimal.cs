using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Animals
{
	/// <summary>
	/// Интерфейс животного
	/// </summary>
	public interface IAnimal
	{
		/// <summary>
		/// Передвигаться
		/// </summary>
		void Move();
	}
}
