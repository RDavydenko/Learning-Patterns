using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod._002_Messangers_and_Messages
{
	public abstract class MessageBase
	{
		/// <summary>
		/// Данные, передаваемые в сообщении
		/// </summary>
		public string Data { get; set; }

		/// <summary>
		/// Отравитель
		/// </summary>
		public string Sender { get; set; }

		/// <summary>
		/// Получатель
		/// </summary>
		public string Recipient { get; set; }

		/// <summary>
		/// Время отправки
		/// </summary>
		public DateTime CreatedTime { get; set; }

		/// <summary>
		/// Отправить сообщение
		/// </summary>
		public abstract void Send();
	}
}
