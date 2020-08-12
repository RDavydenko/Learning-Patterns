using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy._002_Mailer.MailerService
{
	/// <summary>
	/// Осуществляет отправку сообщений пользователям Вконтакте
	/// </summary>
	public class VkontakeMessagesMailerService : IMailerService
	{
		public void Send(string materials)
		{
			// Рассылаем на почту
			Console.WriteLine("Разослали в vk.com");
		}
	}
}
