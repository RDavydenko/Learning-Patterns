using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight._001_Trees_and_Textures
{
	/// <summary>
	/// Дерево
	/// </summary>
	public class Tree
	{
		/// <summary>
		/// Позиция по оси X
		/// </summary>
		public int X { get; set; }

		/// <summary>
		/// Позиция по оси Y
		/// </summary>
		public int Y { get; set; }

		/// <summary>
		/// Типе дерева (в т.ч. спрайт)
		/// </summary>
		private TreeType _treeType;

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="x">Координата по оси X</param>
		/// <param name="y">Координата по оси Y</param>
		/// <param name="treeType">Тип дерева</param>
		public Tree(int x, int y, TreeType treeType)
		{
			X = x;
			Y = y;
			_treeType = treeType;
		}
	}
}
