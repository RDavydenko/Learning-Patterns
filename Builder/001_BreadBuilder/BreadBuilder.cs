using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder._001_BreadBuilder
{
	/// <summary>
	/// Билдер хлеба. Позволяет выполнить настройку нутриентов хлеба
	/// </summary>
	public class BreadBuilder
	{
		/// <summary>
		/// Соль
		/// </summary>
		public double Salt { get; private set; } = 1;

		/// <summary>
		/// Вид муки
		/// </summary>
		public FlourType FlourType { get; private set; } = FlourType.Rye;

		/// <summary>
		/// Мука
		/// </summary>
		public double Flour { get; private set; } = 1;

		/// <summary>
		/// Масло
		/// </summary>
		public double Butter { get; private set; } = 1;

		/// <summary>
		/// Специи
		/// </summary>
		public string[] Spices { get; private set; } = new string[] { };

		/// <summary>
		/// Позволяет установить соль
		/// </summary>
		/// <param name="value">Количество соли</param>
		/// <returns>Возвращает этот экземпляр класса <see cref="BreadBuilder"/></returns>
		public BreadBuilder SetSalt(double value)
		{
			Salt = value;
			return this;
		}

		/// <summary>
		/// Позволяет установить вид муки
		/// </summary>
		/// <param name="type">Вид муки</param>
		/// <returns>Возвращает этот экземпляр класса <see cref="BreadBuilder"/></returns>
		public BreadBuilder SetFlourType(FlourType type)
		{
			FlourType = type;
			return this;
		}

		/// <summary>
		/// Позволяет установить количество муку
		/// </summary>
		/// <param name="value">Количество муки</param>
		/// <returns>Возвращает этот экземпляр класса <see cref="BreadBuilder"/></returns>
		public BreadBuilder SetFlour(double value)
		{
			Flour = value;
			return this;
		}

		/// <summary>
		/// Позволяет установить количество масла
		/// </summary>
		/// <param name="value">Количество масла</param>
		/// <returns>Возвращает этот экземпляр класса <see cref="BreadBuilder"/></returns>
		public BreadBuilder SetButter(double value)
		{
			Butter = value;
			return this;
		}

		/// <summary>
		/// Позволяет установить специи
		/// </summary>
		/// <param name="spices">Добавленные специи</param>
		/// <returns>Возвращает этот экземпляр класса <see cref="BreadBuilder"/></returns>
		public BreadBuilder SetSpices(params string[] spices)
		{
			if (spices != null)
			{
				Spices = spices;
			}
			return this;
		}
	}

	/// <summary>
	/// Виды муки
	/// </summary>
	public enum FlourType
	{
		/// <summary>
		/// Ржаная мука
		/// </summary>
		Rye = 0,

		/// <summary>
		/// Пшеничная
		/// </summary>
		Wheat = 1
	}
}
