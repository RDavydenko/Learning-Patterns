using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Adapter.Transports;

namespace Adapter
{
	/// <summary>
	/// Человек
	/// </summary>
	public class People
	{
		/// <summary>
		/// Средство передвижения
		/// </summary>
		public ITransport Transport { get; private set; }

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="transport">Средство передвижения</param>
		public People(ITransport transport)
		{
			Transport = transport;
		}

		/// <summary>
		/// Ехать к конкретной локации
		/// </summary>
		/// <param name="location">Название локации</param>
		public void MoveTo(string location)
		{
			Console.WriteLine($"Отправляемся в {location}...");
			Transport.Drive();
			Console.WriteLine($"Прибыли в {location}!");
		}

		/// <summary>
		/// Сменить средство передвижения
		/// </summary>
		/// <param name="transport">Новый транспорт</param>
		public void ChangeTransport(ITransport transport)
		{
			Transport = transport;
		}
	}
}
