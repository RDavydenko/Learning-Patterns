using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Transports
{
	/// <summary>
	/// Автомобиль
	/// </summary>
	public class Auto : ITransport
	{
		public void Drive()
		{
			Console.WriteLine("*Едет на автомобиле*");
		}
	}
}
