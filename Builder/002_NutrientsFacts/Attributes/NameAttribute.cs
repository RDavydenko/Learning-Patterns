using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder._002_NutrientsFacts.Attributes
{
	/// <summary>
	/// Создан, для русификации перечислений
	/// </summary>
	public class NameAttribute : Attribute
	{
		/// <summary>
		/// Альтернативное название
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="name">Альтернативное название</param>
		public NameAttribute(string name)
		{
			Name = name;
		}
	}
}
