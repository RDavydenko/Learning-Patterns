using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Doctors
{
	/// <summary>
	/// Медсестра
	/// </summary>
	public class Nurse
	{
		/// <summary>
		/// Подать пинцет
		/// </summary>
		public void GivePincers()
		{
			Console.WriteLine("Медсестра: подала пинцет");
		}

		/// <summary>
		/// Подать скальпель
		/// </summary>
		public void GiveScalpel()
		{
			Console.WriteLine("Медсестра: подала скальпель");
		}
	}
}
