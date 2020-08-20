using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Animals
{
	/// <summary>
	/// Лошадь
	/// </summary>
	public class Horse : IAnimal
	{
		public void Move()
		{
			Console.WriteLine("*Скачет на лошади*");
		}
	}
}
