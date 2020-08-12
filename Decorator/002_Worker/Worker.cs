using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Decorator._002_Worker
{
	/// <summary>
	/// Класс, который делает какую-то работу
	/// </summary>
	public class Worker
	{
		/// <summary>
		/// Делает какую-то работу
		/// </summary>
		/// <param name="information">Необходимые данные</param>
		/// <returns>Результат работы</returns>
		public virtual string DoSomeWork(string information)
		{
			Thread.Sleep(1000); // Имитация работы
			Random r = new Random();

			// Результат работы
			var result = $"Результат работы: {r.Next(100 + 1)} из 100 корректных работ";
			Console.WriteLine(result);
			return result;
		}
	}
}
