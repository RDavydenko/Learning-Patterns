using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight._001_Trees_and_Textures
{
	/// <summary>
	/// Содержит информацию о дереве
	/// </summary>
	public class TreeType
	{
		/// <summary>
		/// Название
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Автор
		/// </summary>
		public string Author { get; }

		/// <summary>
		/// Спрайт
		/// </summary>
		private byte[] _sprite;

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="name">Название</param>
		/// <param name="author">Автор</param>
		/// <param name="sprite">Спрайт</param>
		public TreeType(string name, string author, byte[] sprite)
		{
			Name = name;
			Author = author;
			_sprite = sprite;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
