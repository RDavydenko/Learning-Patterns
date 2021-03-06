﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bridge._002_CustomFigures.Colors;
using Bridge._002_CustomFigures.Customizations;

namespace Bridge._002_CustomFigures.Figures
{
	/// <summary>
	/// Куб
	/// </summary>
	public class Cube : IColored
	{
		public string Name { get; } = "Куб";
		
		public IColor Color { get; set; }

		public override string ToString()
		{
			return $"Фигура: {Name}\n" +
				   $"Цвет: {Color?.Name}";
		}
	}
}
