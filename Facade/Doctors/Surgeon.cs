using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Facade.Extensions;

namespace Facade.Doctors
{
	/// <summary>
	/// Хирург
	/// </summary>
	public class Surgeon
	{
		/// <summary>
		/// Разрезать часть тела
		/// </summary>
		/// <param name="bodyPart">Часть тела</param>
		public void Cut(BodyPart bodyPart)
		{
			var part = bodyPart.Russify();
			Console.WriteLine($"Хирург: разрезал часть тела - {part}");
		}

		/// <summary>
		/// Зашить часть тела
		/// </summary>
		/// <param name="bodyPart">Часть тела</param>
		public void Sew(BodyPart bodyPart)
		{
			var part = bodyPart.Russify();
			Console.WriteLine($"Хирург: зашил часть тела - {part}");
		}

		/// <summary>
		/// Вырезать поврежденную часть тела
		/// </summary>
		/// <param name="bodyPart">Часть тела</param>
		public void Clear(BodyPart bodyPart)
		{
			var part = bodyPart.Russify();
			Console.WriteLine($"Хирург: вырезал поврежденное из части тела - {part}");
		}
	}
}
