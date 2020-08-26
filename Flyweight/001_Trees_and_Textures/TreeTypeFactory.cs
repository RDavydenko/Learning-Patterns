using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight._001_Trees_and_Textures
{
	/// <summary>
	/// Фабрика типов деревьев (для минимизации использования ОЗУ)
	/// </summary>
	public class TreeTypeFactory
	{
		/// <summary>
		/// Типы деревьев в памяти программы (Тип / ключ)
		/// </summary>
		private List<Tuple<TreeType, string>> _treeTypes;

		/// <summary>
		/// Конструктор класса
		/// </summary>
		public TreeTypeFactory()
		{
			_treeTypes = new List<Tuple<TreeType, string>>();
		}

		/// <summary>
		/// Вернуть объект <see cref="TreeType"/>
		/// </summary>
		/// <param name="treeType">Необходимый объект типа <see cref="TreeType"/></param>
		/// <returns>Новый/существующий объект типа <see cref="TreeType"/></returns>
		public TreeType GetTreeType(TreeType treeType)
		{
			var key = GetKey(treeType); // Ключ объекта
			var existing = _treeTypes.FirstOrDefault(t => t.Item2 == key);
			if (existing == null) // Не существует --> создаем
			{
				_treeTypes.Add(new Tuple<TreeType, string>(treeType, key));
				Console.WriteLine("Создан новый объект TreeType, возвращаем новый.");
				return treeType;
			}
			else // Если существует --> возвращаем существующий
			{
				Console.WriteLine("Объект TreeType уже существует, возвращаем существующий.");
				return existing.Item1;
			}
		}

		/// <summary>
		/// Возвращает ключ объекта <see cref="TreeType"/>
		/// </summary>
		/// <param name="treeType"></param>
		/// <returns>Ключ</returns>
		private string GetKey(TreeType treeType)
		{
			return treeType.Name + "_" + treeType.Author;
		}
	}
}
