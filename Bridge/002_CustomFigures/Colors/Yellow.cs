using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge._002_CustomFigures.Colors
{
	/// <summary>
	/// Желтый цвет
	/// </summary>
	public class Yellow : IColor
	{
		public string Name { get; } = "Желтый";

		public Color Color { get; } = Color.Yellow;
	}
}
