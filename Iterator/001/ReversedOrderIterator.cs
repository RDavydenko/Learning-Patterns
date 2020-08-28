using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator._001
{
	/// <summary>
	/// Итератор с возможностью следования обратному порядку
	/// </summary>
	public class ReversedOrderIterator : IteratorBase<string>
	{
		public override string Current
		{
			get
			{
				return _collection[_position];
			}
		}

		private WordsCollection _collection;
		private bool _reversed;

		private int _position = -1;

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="collection">Коллекция слов</param>
		/// <param name="reversed">В обратном порядке алфавита или нет</param>
		public ReversedOrderIterator(WordsCollection collection, bool reversed = false)
		{
			_reversed = reversed;
			_collection = collection;

			if (reversed)
			{
				_position = collection.Count();
			}
		}

		public override bool MoveNext()
		{
			int updatedPosition = _position + (_reversed ? -1 : 1);

			if (updatedPosition >= 0 && updatedPosition < _collection.Count())
			{
				_position = updatedPosition;
				return true;
			}
			else
			{
				return false;
			}
		}

		public override void Reset()
		{
			_position = _reversed ? _collection.Count() - 1 : 0;
		}
	}
}
