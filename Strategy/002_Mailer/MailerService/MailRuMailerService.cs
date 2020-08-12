using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy._002_Mailer.MailerService
{
	/// <summary>
	/// Почтовый сервис Mail.Ru
	/// </summary>
	public class MailRuMailerService : IMailerService
	{
		public void Send(string materials)
		{
			// Рассылаем на почту
			Console.WriteLine("Разослали на mail.ru");
		}
	}
}
