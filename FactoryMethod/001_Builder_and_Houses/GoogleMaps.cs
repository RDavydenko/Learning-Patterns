using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod._001_Builder_and_Houses
{
	/// <summary>
	/// Класс, отвещающий за наполнение необходимыми данными мобильное приложение "Карты"
	/// </summary>
	public class GoogleMaps
	{
		/// <summary>
		/// Список домов на карте города
		/// </summary>
		private List<IHouse> Houses;


		public GoogleMaps()
		{
			Houses = new List<IHouse>();
		}


		/// <summary>
		/// Добавить новый дом на карту
		/// </summary>
		/// <param name="house">Постройка</param>
		public void Add(IHouse house)
		{
			Houses.Add(house);
		}

		/// <summary>
		/// Добавить несколько новых домов на карту
		/// </summary>
		/// <param name="houses">Список домов</param>
		public void AddRange(IEnumerable<IHouse> houses)
		{
			Houses.AddRange(houses);
		}

		/// <summary>
		/// Добавить несколько новых домов на карту
		/// </summary>
		/// <param name="houses">Список домов</param>
		public void AddRange(params IHouse[] houses)
		{
			Houses.AddRange(houses);
		}

		/// <summary>
		/// Получить список всех домов, нанесенных на карту
		/// </summary>
		/// <returns>Список построек</returns>
		public List<IHouse> GetHouses()
		{
			return Houses;
		}

		/// <summary>
		/// Получить список всех домов, соответствующих заданному условию
		/// </summary>
		/// <param name="predicate">Условие добавления</param>
		/// <returns>Список построек</returns>
		public List<IHouse> GetHouses(Func<IHouse, bool> predicate)
		{
			List<IHouse> result = new List<IHouse>();
			for (int i = 0; i < Houses.Count; i++)
			{
				if (predicate(Houses[i]) == true)
				{
					result.Add(Houses[i]);
				}
			}
			return result;
		}
	}
}
