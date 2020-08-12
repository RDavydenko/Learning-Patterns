using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy._002_Mailer.MailerService
{
	/// <summary>
	/// Интерфейс сервиса сообщений
	/// </summary>
	public interface IMailerService
	{
		/// <summary>
		///  Отправляет письмо
		/// </summary>
		/// <param name="materials">Письмо</param>
		void Send(string materials);
	}
}
