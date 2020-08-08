using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod._002_Messangers_and_Messages.Messages
{
	public class TelegramMessage : MessageBase
	{
		public override void Send()
		{
			// Связываемся с API Телеграма и отправляем сообщение
			Console.WriteLine("Отправлено сообщение в телеграм");
		}
	}
}
