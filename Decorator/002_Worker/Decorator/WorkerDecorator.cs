using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator._002_Worker.Decorator
{
	/// <summary>
	/// Декоратор класса <see cref="_002_Worker.Worker"/>
	/// </summary>
	public abstract class WorkerDecorator : Worker
	{
		/// <summary>
		/// Декорируемый экземпляр класса
		/// </summary>
		protected Worker Worker { get; set; }

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="worker">Декорируемый экземпляр класса <see cref="_002_Worker.Worker"/></param>
		public WorkerDecorator(Worker worker) : base()
		{
			Worker = worker ?? throw new ArgumentNullException(nameof(worker));			
		}		
	}
}
