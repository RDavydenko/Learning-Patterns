using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Facade.Doctors;
using Facade.Extensions;

namespace Facade
{
	class Program
	{
		static void Main(string[] args)
		{
			var _surgeon = new Surgeon(); // Хирург
			var _anesthesiologist = new Anesthesiologist(); // Анестезиолог
			var _nurse = new Nurse(); // Медсестра
			var _surgery = new Surgery(_surgeon, _anesthesiologist, _nurse); // Фасадирует 3 класса: хирурга, анестезиолога и медсестру

			_surgery.DoKneeSurgery(); // Сделать операцию на колено
			Console.WriteLine();

			_surgery.DoBrainSurgery(); // Сделать операцию на мозг
			Console.WriteLine();
		}
	}
}
