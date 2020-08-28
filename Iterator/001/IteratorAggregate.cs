using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator._001
{
	/// <summary>
	/// Базовый класс, реализующий <see cref="IEnumerable{T}"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class IteratorAggregate<T> : IEnumerable<T>
	{
		public abstract IEnumerator<T> GetEnumerator();		

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
