using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight._001_Trees_and_Textures
{
	/// <summary>
	/// Лес (использует много деревьев)
	/// </summary>
	public class Forest
	{
		/// <summary>
		/// Деревья
		/// </summary>
		public List<Tree> Trees { get; private set; }

		/// <summary>
		/// Конструктор класса		
		/// </summary>
		/// <param name="treesCount">Количество деревьев</param>
		/// <exception cref="ArgumentOutOfRangeException">Если параметр <paramref name="treesCount"/> меньше нуля</exception>
		public Forest(int treesCount)
		{
			if (treesCount < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(treesCount));
			}
			Trees = new List<Tree>(treesCount);
		}

		/// <summary>
		/// Инициализирует лес новыми деревьями
		/// </summary>
		/// <param name="trees">Деревья</param>
		/// <exception cref="ArgumentNullException">Если параметр <paramref name="trees"/> равен <see langword="null"/></exception>
		/// <exception cref="ArgumentOutOfRangeException">Если количество элементов параметра <paramref name="trees"/> больше количества деревьев леса <see cref="Forest.Trees"/></exception>
		public void InitializeTrees(IEnumerable<Tree> trees)
		{
			if (trees == null)
			{
				throw new ArgumentNullException(nameof(trees));
			}
			if (trees.Count() > Trees.Capacity)
			{
				throw new ArgumentOutOfRangeException(nameof(trees));
			}
			for (int i = 0; i < trees.Count(); i++)
			{
				Trees.Add(trees.ElementAt(i));
			}
		}
	}
}
