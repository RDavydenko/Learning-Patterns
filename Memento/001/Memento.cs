using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento._001
{
	/// <summary>
	/// Снимок
	/// </summary>
	public class Memento : IMemento
	{
		private DateTime _date;

		private string _name;

		private readonly TextEditor _backup;

		public Memento(TextEditor textEditor, string name)
		{
			_backup = textEditor;
			_name = name;
			_date = DateTime.Now;
		}

		public DateTime GetDate()
		{
			return _date;
		}

		public string GetName()
		{
			return _name;
		}

		public TextEditor GetBackup()
		{
			return _backup;
		}
	}
}
