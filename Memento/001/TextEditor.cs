using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento._001
{
	public class TextEditor : ICloneable
	{
		/// <summary>
		/// Ширина поля
		/// </summary>
		public int Width { get; set; }

		/// <summary>
		/// Высота поля
		/// </summary>
		public int Height { get; set; }

		/// <summary>
		/// Автор текста
		/// </summary>
		public string Author { get; private set; }

		/// <summary>
		/// Строки
		/// </summary>
		private List<string> _lines = new List<string>();

		/// <summary>
		/// Конструктор класса
		/// </summary>
		public TextEditor()
		{
			Author = "Roman";
		}

		/// <summary>
		/// Добавить строку
		/// </summary>
		/// <param name="line">Строка</param>
		public void AddLine(string line)
		{
			if (string.IsNullOrWhiteSpace(line))
			{
				throw new ArgumentException("message", nameof(line));
			}
			_lines.Add(line.Trim().ToLower());
		}

		/// <summary>
		/// Сделать бэкап состояния
		/// </summary>
		/// <param name="name">Название бэкапа</param>
		/// <returns>Снимок состояния</returns>
		public IMemento DoBackup(string name)
		{
			var memento = new Memento(this.Clone() as TextEditor, name);
			Console.WriteLine("Сделан новый снимок с именем: " + name);
			return memento;
		}

		/// <summary>
		/// Восстанавливает состояние объекта из снимка
		/// </summary>
		/// <param name="memento">Снимок</param>
		/// <returns><see langword="true"/>, если восстановление удалось</returns>
		public bool Restore(IMemento memento)
		{
			if (memento != null)
			{
				var state = memento.GetBackup(); // Состояние объекта на момент снимка
				this.Width = state.Width;
				this.Height = state.Height;
				this.Author = state.Author;
				this._lines = state._lines;
				
				Console.WriteLine("Восстановлено состояние из снимка с именем: " + memento.GetName());

				return true;
			}
			return false;
		}

		public object Clone()
		{
			var t = new TextEditor();
			t.Width = this.Width;
			t.Height = this.Height;
			t.Author = this.Author;
			List<string> lines = new List<string>();
			foreach (var line in _lines)
			{
				lines.Add(line);
			}
			t._lines = lines;
			return t;
		}

		public override string ToString()
		{
			var sr = new StringBuilder();
			sr.AppendFormat("Ширина: {0}\n", Width);
			sr.AppendFormat("Высота: {0}\n", Height);
			sr.AppendFormat("Автор: {0}\n", Author);
			sr.AppendLine("Текст:");
			foreach (var line in _lines)
			{
				sr.Append("\t");
				sr.AppendLine(line);
			}
			return sr.ToString();
		}
	}
}
