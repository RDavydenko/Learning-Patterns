using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod._002_Messangers_and_Messages
{
	public abstract class MessangerBase
	{
		/// <summary>
		/// Название мессенджера
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// Создать сообщение 
		/// </summary>
		/// <param name="data">Данные</param>
		/// <param name="sender">Отправитель</param>
		/// <param name="recipient">Получатель</param>
		/// <param name="creatingTime">Время создания</param>
		/// <returns></returns>
		public abstract MessageBase CreateMessage(string data, string sender, string recipient, DateTime creatingTime);
	}
}
