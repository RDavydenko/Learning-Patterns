using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator._001
{
	/// <summary>
	/// Коллекция слов
	/// </summary>
	public class WordsCollection : IteratorAggregate<string>
	{
		private List<string> _words;

		/// <summary>
		/// Обратный порядок или нет
		/// </summary>
		public bool Reversed { get; set; } = false;

		public WordsCollection(params string[] words)
		{
			_words = new List<string>(words);
		}

		public string this[int index]
		{
			get { return _words[index]; }
			set { _words[index] = value; }
		}

		public override IEnumerator<string> GetEnumerator()
		{
			return new ReversedOrderIterator(this, Reversed);
		}

		public void Add(string item)
		{
			if (string.IsNullOrWhiteSpace(item))
			{
				throw new ArgumentException("", nameof(item));
			}
			_words.Add(item);
		}

		public List<string> GetItems()
		{
			return _words;
		}

		public int Count()
		{
			return _words.Count;
		}
	}
}
