using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bridge._002_CustomFigures.Colors;

namespace Bridge._002_CustomFigures.Customizations
{
	/// <summary>
	/// Интерфейс окрашенного класса
	/// </summary>
	public interface IColored
	{
		/// <summary>
		/// Цвет
		/// </summary>
		IColor Color { get; }
	}
}
