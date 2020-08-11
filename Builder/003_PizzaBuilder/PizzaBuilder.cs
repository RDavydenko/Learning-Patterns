using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder._003_PizzaBuilder
{
	/// <summary>
	/// Абстрактный класс билдера пиццы
	/// </summary>
	public abstract class PizzaBuilder
	{
		/// <summary>
		/// Диаметр
		/// </summary>
		public int Diameter { get; private set; } = 30;

		/// <summary>
		/// Количество кусочков
		/// </summary>
		public int PortionsCount { get; private set; }  = 6;

		/// <summary>
		/// Присутствует сыр?
		/// </summary>
		public bool HasCheese  { get; private set; } = true;

		/// <summary>
		/// Установить диаметр
		/// </summary>
		/// <param name="diameter">Диаметр</param>
		/// <returns>Этот экземпляр класса билдера</returns>
		public virtual PizzaBuilder SetDiameter(int diameter)
		{
			if (diameter <= 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			Diameter = diameter;
			return this;
		}

		/// <summary>
		/// Установить количество порций
		/// </summary>
		/// <param name="portionsCount">Количество порций</param>
		/// <returns>Этот экземпляр класса билдера</returns>
		public virtual PizzaBuilder SetPortionsCount(int portionsCount)
		{
			if (portionsCount <= 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			PortionsCount = portionsCount;
			return this;
		}

		/// <summary>
		/// Установить наличие сыра. <see langword="true"/> если сыр есть, <see langword="false"/>, если сыра нет
		/// </summary>
		/// <param name="hasCheese"><see langword="true"/> если сыр есть, <see langword="false"/>, если сыра нет</param>
		/// <returns>Этот экземпляр класса билдера</returns>
		public virtual PizzaBuilder SetCheese(bool hasCheese)
		{
			HasCheese = hasCheese;
			return this;
		}

		/// <summary>
		/// Возвращает построенный экземпляр класса <see cref="Pizza"/>
		/// </summary>
		/// <returns>Экземпляр класса <see cref="Pizza"/></returns>
		public virtual Pizza Build()
		{
			return new Pizza
			{
				Diameter = Diameter,
				HasCheese = HasCheese,
				PortionsCount = PortionsCount
			};
		}
	}
}
