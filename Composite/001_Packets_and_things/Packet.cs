using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite._001_Packets_and_things
{
	/// <summary>
	/// Упаковка
	/// </summary>
	public class Packet : IThing
	{
		/// <summary>
		/// Название
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Базовая стоимость
		/// </summary>
		public decimal BaseCost { get; }

		/// <summary>
		/// Базовый вес
		/// </summary>
		public double BaseWeight { get; }

		/// <summary>
		/// Вложенные компоненты
		/// </summary>
		public List<IThing> Components { get; }

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="name">Название упаковки</param>
		/// <param name="cost">Стоимость упаковки</param>
		/// <param name="weight">Вес упаковки</param>
		public Packet(string name, decimal cost, double weight)
		{
			Name = name;
			BaseCost = cost;
			BaseWeight = weight;
			Components = new List<IThing>();
		}

		/// <summary>
		/// Добавить компонент
		/// </summary>
		/// <param name="component">Компонент</param>
		public void AddComponent(IThing component)
		{
			if (component == null)
			{
				throw new ArgumentNullException(nameof(component));
			}
			Components.Add(component);
		}

		/// <summary>
		/// Удалить компонент
		/// </summary>
		/// <param name="component">Компонент</param>
		public void RemoveComponent(IThing component)
		{
			if (component == null)
			{
				throw new ArgumentNullException(nameof(component));
			}
			Components.Remove(component);
		}

		public decimal GetCost()
		{
			Console.WriteLine($"Считаем стоимость: {Name}");

			decimal componentsCost = 0;
			foreach (var component in Components)
			{
				componentsCost += component.GetCost();				
			}
			return componentsCost + BaseCost;
		}

		public double GetWeight()
		{
			Console.WriteLine($"Считаем вес: {Name}");

			double componentsWeight = 0;
			foreach (var component in Components)
			{
				componentsWeight += component.GetWeight();
			}
			return componentsWeight + BaseWeight;
		}
	}
}
