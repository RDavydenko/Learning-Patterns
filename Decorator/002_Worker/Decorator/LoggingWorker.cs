using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator._002_Worker.Decorator
{
	/// <summary>
	/// Декоратор класса <see cref="Worker"/>.
	/// Добавляет логирование результата в файл.
	/// </summary>
	public class LoggingWorker : WorkerDecorator
	{
		/// <summary>
		/// Путь к файлу логов
		/// </summary>
		private string logFilePath;	

		/// <summary>
		/// Конструктор файла
		/// </summary>
		/// <param name="worker">Декорируемый класс <see cref="Worker"/></param>
		/// <param name="logFilePath">Путь к файлу логов</param>
		public LoggingWorker(Worker worker, string logFilePath = "logs.txt") : base(worker)
		{
			this.logFilePath = logFilePath;
		}

		public override string DoSomeWork(string information)
		{
			var result = Worker.DoSomeWork(information);

			// Декорируем класс Worker, подключив логирование результатов
			LogInfo(result);
			Console.WriteLine("Произвели логирование информации");

			return result;
		}

		/// <summary>
		/// Логирует информацию в файл
		/// </summary>
		/// <param name="log">Лог</param>
		private void LogInfo(string log)
		{
			// Декорируем класс Worker, подключив логирование результатов
			using (StreamWriter sw = new StreamWriter(logFilePath, true))
			{
				sw.WriteLine($"[{DateTime.Now}]: {log}"); // Записываем строку в файл
				sw.Close();
			}
		}
	}
}
