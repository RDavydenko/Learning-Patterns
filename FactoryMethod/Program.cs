using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FactoryMethod._001_Builder_and_Houses;
using FactoryMethod._001_Builder_and_Houses.Builders;
using FactoryMethod._001_Builder_and_Houses.Houses;

namespace FactoryMethod
{
	class Program
	{
		/// <summary>
		/// Проверяем работу паттерна Фабричный метод на примере застройщиков и построек
		/// </summary>
		static void HousesAndBuilders()
		{
			GoogleMaps maps = new GoogleMaps(); // Класс, работающий с постройками через интерфейс IHouse

			var forestBuilder = new ForestBuilder(); // Застройщик 1
			var algoritmBuilder = new AlgoritmBuilder(); // Застройщик 2 
			var sunlightBuilder = new SunlightBuilder(); // Застройщик 3

			IHouse house1 = forestBuilder.Build(); // Постройка от застройщика 1
			IHouse house2 = algoritmBuilder.Build(); // Постройка от застройщика 2
			IHouse house3 = sunlightBuilder.Build(); // Постройка от застройщика 3

			maps.AddRange(house1, house2, house3);
			var allHouses = maps.GetHouses();
			var highHouses = maps.GetHouses(h => h.Floors > 5);
		}

		static void Main(string[] args)
		{
			
		}
	}
}
