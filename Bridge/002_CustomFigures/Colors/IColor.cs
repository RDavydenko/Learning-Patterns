using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge._002_CustomFigures.Colors
{
	/// <summary>
	/// Интерфейс цвета
	/// </summary>
	public interface IColor
	{
		/// <summary>
		/// Наименование цвета
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Цвет
		/// </summary>
		Color Color { get; }
	}
}
