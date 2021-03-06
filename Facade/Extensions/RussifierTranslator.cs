﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Facade.Attributes;

namespace Facade.Extensions
{
	/// <summary>
	/// С помощью рефлексии возвращает название <see cref="RussifierAttribute.Name"/> из атрибута <see cref="RussifierAttribute"/> для перечислений.
	/// </summary>
	static class RussifierTranslator
	{
		public static string Russify(this Enum obj)
		{
			var attrs = obj.GetType().GetMember(obj.ToString())[0].GetCustomAttributes(true);
			string name = string.Empty;
			foreach (var attr in attrs)
			{
				if (attr is RussifierAttribute)
				{
					name = (attr as RussifierAttribute).Name;
					break;
				}
			}
			return name;
		}
	}
}
