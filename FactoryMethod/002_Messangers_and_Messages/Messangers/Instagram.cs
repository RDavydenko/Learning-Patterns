using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod._002_Messangers_and_Messages.Messages;

namespace FactoryMethod._002_Messangers_and_Messages.Messangers
{
	public class Instagram : MessangerBase
	{
		public override MessageBase CreateMessage(string data, string sender, string recipient, DateTime creatingTime)
		{
			// Здесь можно выполнять еще какие-то действия, например анализировать фотографии с помощью нейросети
			// Свобода к расширению функционала

			return new PhotoInstagram { Data = data, Sender = sender, Recipient = recipient, CreatedTime = creatingTime };
		}
	}
}
