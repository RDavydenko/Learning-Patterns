using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype._001
{
	/// <summary>
	/// Машина, реализующая интерфейс <see cref="ICloneable"/>
	/// </summary>
	public class Car : ICloneable
	{
		/// <summary>
		/// Максимальная скорость
		/// </summary>
		public int MaxSpeed { get; set; }

		/// <summary>
		/// Количество топлива
		/// </summary>
		public int Oil { get; set; }

		public object Clone()
		{
			var car = new Car() { MaxSpeed = this.MaxSpeed, Oil = this.Oil };
			return car;
		}
	}
}
