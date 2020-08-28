using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator._001
{
	/// <summary>
	/// Базовый класс итератора
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class IteratorBase<T> : IEnumerator<T>
	{
		public abstract T Current { get; }

		object IEnumerator.Current { get; }

		public virtual void Dispose()
		{
			
		}

		public abstract bool MoveNext();
		public abstract void Reset();
	}
}
