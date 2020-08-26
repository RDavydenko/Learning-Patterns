using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Flyweight._001_Trees_and_Textures;

namespace Flyweight
{
	class Program
	{
		static void Main(string[] args)
		{
			TreesAndTexturesTest(); // 001
		}

		/// <summary>
		/// Тестируем первый пример реализации паттерна Flyweight (Легковес)
		/// </summary>
		private static void TreesAndTexturesTest()
		{
			var treeTypeFactory = new TreeTypeFactory(); // Фабрика TreeType

			// Получаем деревья (часть создается, часть берется из кэша)
			// Подразумевается, что параметр byte[] sprite будет весить очень много, потому что является текстурой дерева
			// Если хранить текстуру у каждого дерева, то может не хватить памяти. А так в каждом дереве хранится ссылка на тип, в котором есть текстура
			var treeType = treeTypeFactory.GetTreeType(new TreeType("Осеннее дерево", "Роман", new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
			var treeType2 = treeTypeFactory.GetTreeType(new TreeType("Летнее дерево", "Роман", new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
			var treeType3 = treeTypeFactory.GetTreeType(new TreeType("Осеннее дерево", "Роман", new byte[] { 0, 9, 8, 7, 6, 5, 4, 3, 2, 1 }));
			var types = new TreeType[]
			{
				treeType,
				treeType2,
				treeType3
			};

			// Заполняем лес легковесными деревьями в количестве 1000000 (млн)
			var rnd = new Random();
			int treesCount = 1000000; // Количество деревьев в лесу
			var trees = new List<Tree>(treesCount);
			for (int i = 0; i < treesCount; i++)
			{
				var type = types[rnd.Next(types.Length)];
				var tree = new Tree(rnd.Next(1000), rnd.Next(1000), type);
				trees.Add(tree);
			}

			var forest = new Forest(treesCount);
			forest.InitializeTrees(trees); // Добавляем деревья в лес
		}
	}
}
