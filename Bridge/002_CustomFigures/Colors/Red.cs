using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge._002_CustomFigures.Colors
{
	/// <summary>
	/// Красный цвет
	/// </summary>
	public class Red : IColor
	{
		public string Name { get; } = "Красный";

		public Color Color { get; } = Color.Red;
	}
}
