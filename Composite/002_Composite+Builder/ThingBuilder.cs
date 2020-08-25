using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Composite._001_Packets_and_things;

namespace Composite._002_Composite_Builder
{
	/// <summary>
	/// Билдер для классов <see cref="Packet"/> и <see cref="Thing"/>, реализующих интерфейс <see cref="IThing"/>
	/// </summary>
	public class ThingBuilder
	{
		private Packet Root { get; }

		private Packet CurrentPacket { get; set; }

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="name">Название главного пакета <see cref="Packet"/></param>
		/// <param name="cost">Базовая стоимость главного пакета <see cref="Packet"/></param>
		/// <param name="weight">Базовый вес главного пакета <see cref="Packet"/></param>
		public ThingBuilder(string name, decimal cost = 0, double weight = 0)
		{
			Root = new Packet(name, cost, weight); // Создаем корневую упаковку
			CurrentPacket = Root;
		}

		/// <summary>
		/// Добавить пакет в текущий пакет
		/// </summary>
		/// <param name="name">Название пакета</param>
		/// <param name="cost">Базовая стоимость пакета</param>
		/// <param name="weight">Базовый вес пакета</param>
		/// <returns>Экземпляр класса билдера</returns>
		public ThingBuilder AddPacket(string name, decimal cost = 0, double weight = 0)
		{
			var packet = new Packet(name, cost, weight);
			CurrentPacket.Components.Add(packet); // Добавляем новый пакет в текущий пакет

			return this;
		}

		/// <summary>
		/// Добавить вещь в текущий пакет
		/// </summary>
		/// <param name="name">Название вещи</param>
		/// <param name="cost">Стоимость вещи</param>
		/// <param name="weight">Вес вещи</param>
		/// <returns>Экземпляр класса билдера</returns>
		public ThingBuilder AddThing(string name, decimal cost = 0, double weight = 0)
		{
			var thing = new Thing(name, cost, weight);
			CurrentPacket.Components.Add(thing); // Добавляем новый пакет в текущий пакет

			return this;
		}

		/// <summary>
		/// Сменить текущий пакет
		/// </summary>
		/// <param name="name">Название существующего пакета</param>
		/// <returns>Экземпляр класса билдера</returns>
		/// <exception cref="ArgumentException">Выбрасывается, когда пакет с именем <paramref name="name"/> не найден ни на одном уровне вложенности.</exception>
		public ThingBuilder SetCurrentPacket(string name)
		{
			// Обходим все пакеты, начиная с Root, задействуя все уровни вложенности
			var packetsStack = new Stack<Packet>();
			packetsStack.Push(Root);
			while (packetsStack.Count != 0)
			{
				var currentPacket = packetsStack.Pop();
				if (currentPacket.Name == name)
				{
					CurrentPacket = currentPacket;
					return this;
				}

				foreach (var packet in currentPacket.Components.OfType<Packet>())
				{
					packetsStack.Push(packet);
				}
			}

			// Если функция не завершилась раньше, значит такого пакета не существует ни на каком уровне вложенности
			throw new ArgumentException($"Не найден ни один пакет с именем {nameof(name)}");
		}


		/// <summary>
		/// Вернуть построенный пакет (корневой)
		/// </summary>
		/// <returns>Построенный корневой пакет <see cref="Packet"/></returns>
		public Packet Build()
		{
			return Root;
		}
	}
}
