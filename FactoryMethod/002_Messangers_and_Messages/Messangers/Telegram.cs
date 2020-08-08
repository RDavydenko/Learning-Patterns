using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod._002_Messangers_and_Messages.Messages;

namespace FactoryMethod._002_Messangers_and_Messages.Messangers
{
	/// <summary>
	/// Телеграмм мессенджер
	/// </summary>
	public class Telegram : MessangerBase
	{
		public override MessageBase CreateMessage(string data, string sender, string recipient, DateTime creatingTime)
		{
			// Здесь можно выполнять еще какие-то действия, например отправлять подозрительные сообщения в органы XD
			// if (data.Contains("терракт")) SendToPolicy(data, sender, recipient, creatingTime);
			// Свобода к расширению функционала

			return new TelegramMessage { Data = data, Sender = sender, Recipient = recipient, CreatedTime = creatingTime };
		}
	}
}
