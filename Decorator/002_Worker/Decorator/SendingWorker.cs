using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator._002_Worker.Decorator
{
	/// <summary>
	/// Декоратор класса <see cref="Worker"/>.
	/// Добавляет отправку результата работы на почту.
	/// </summary>
	public class SendingWorker : WorkerDecorator
	{
		public SendingWorker(Worker worker) : base(worker) { }

		public override string DoSomeWork(string information)
		{
			var result = Worker.DoSomeWork(information);

			// Декорируем класс, Worker отправляя на почту программисту данные
			Console.WriteLine("Отправили на почту: " + result);

			return result;			
		}
	}
}
