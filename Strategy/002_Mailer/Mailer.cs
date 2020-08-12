using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy._002_Mailer.DelivererMaterials;
using Strategy._002_Mailer.MailerService;

namespace Strategy._002_Mailer
{
	/// <summary>
	/// Занимается рассылкой материалов
	/// </summary>
	public class Mailer
	{
		/// <summary>
		/// Доставщик информации
		/// </summary>
		private readonly IDelivererMaterials _delivererMaterialsBehavior;

		/// <summary>
		/// Почтовый сервис рассылки
		/// </summary>
		private readonly IMailerService _mailerServiceBehavior;

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="delivererMaterialsBehavior">Реализация доставщика информации</param>
		/// <param name="mailerServiceBehavior">Реализации почтового сервиса</param>
		public Mailer(IDelivererMaterials delivererMaterialsBehavior, IMailerService mailerServiceBehavior)
		{
			_delivererMaterialsBehavior = delivererMaterialsBehavior;
			_mailerServiceBehavior = mailerServiceBehavior;
		}

		/// <summary>
		/// Осуществляет рассылку
		/// </summary>
		public void Mail()
		{
			var materials = _delivererMaterialsBehavior.GetMaterials(); // Получаем материалы
			Console.WriteLine("Получены материалы: " + materials);

			_mailerServiceBehavior.Send(materials); // Расслаем материалы
		}
	}
}
