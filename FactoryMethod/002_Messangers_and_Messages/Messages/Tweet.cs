using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod._002_Messangers_and_Messages.Messages
{
	public class Tweet : MessageBase
	{
		public override void Send()
		{
			// Связываемся с API Твиттера и отправляем сообщение
			Console.WriteLine("Отправлен твит в твиттер");
		}
	}
}
