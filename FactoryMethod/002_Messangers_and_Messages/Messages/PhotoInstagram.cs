using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod._002_Messangers_and_Messages.Messages
{
	/// <summary>
	/// Инстаграм
	/// </summary>
	public class PhotoInstagram : MessageBase
	{
		public override void Send()
		{
			// Связываемся с серверами Инстаграма и отправляем сообщение
			Console.WriteLine("Отправлена фотография в инстаграм");
		}
	}
}
