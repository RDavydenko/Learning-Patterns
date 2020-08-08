using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Singleton._001_Logger;
using Singleton._002_Patient;

namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			Logger logger = Logger.GetInstance(); // Singleton логгер
			logger.AddLog("Динамический лог 1"); // Добавляем лог в ОЗУ
			logger.AddLog("Динамический лог 2"); // Добавляем лог в ОЗУ
			var allLogs = logger.GetLogs();
			var periodLogs = logger.GetLogs(new DateTime(2020, 8, 7, 21, 54, 0), new DateTime(2020, 8, 7, 21, 57, 0));
			logger.Save(); // Сохраняем логи на диск
			var allLogs2 = logger.GetLogs();

			Patient patient = Patient.Instance;
			patient.Init(18, Sex.Male, 70.8, 176, 60);
			Console.WriteLine(patient.ToString());

			Console.WriteLine();

			Patient patient2 = Patient.Instance;
			Console.WriteLine(patient2.ToString());
		}
	}
}
