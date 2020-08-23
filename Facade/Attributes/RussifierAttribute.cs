using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Attributes
{
	/// <summary>
	/// Руссификатор для перечислений
	/// </summary>
	class RussifierAttribute : Attribute
	{
		/// <summary>
		/// Название на русском
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="name">Название на русском</param>
		public RussifierAttribute(string name)
		{
			Name = name;
		}
	}
}
