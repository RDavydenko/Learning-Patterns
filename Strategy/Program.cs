using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy._001_CloudServices;
using Strategy._001_CloudServices.CloudServices;
using Strategy._002_Mailer;
using Strategy._002_Mailer.DelivererMaterials;
using Strategy._002_Mailer.MailerService;

namespace Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			CloudServiceTest(); // 001
			Console.WriteLine();

			MailerServiceTest(); // 002
			Console.WriteLine();
		}
		
		/// <summary>
		/// Тестируем первый пример паттерна Стратегия (облачные сервисы)
		/// </summary>
		private static void CloudServiceTest()
		{
			// Создали воркера, который будет работать с Amazon
			Worker amazonWorker = new Worker(new AmazonCloudService());

			// Создали воркера, который будет работать с Azure
			Worker azureWorker = new Worker(new AzureCloudService());

			// Работаем с Amazon
			amazonWorker.DoWork().Wait();

			// Работаем с Azure
			azureWorker.DoWork().Wait();
		}

		/// <summary>
		/// Тестируем второй пример паттерна Стратегия (рассылка материалов)
		/// </summary>
		private static void MailerServiceTest()
		{
			Mailer mailer1 = new Mailer(new ParserHabra(), new MailRuMailerService()); // Рассыльщик статей с хабра на почту маил ру
			Mailer mailer2 = new Mailer(new GeneratorMemes(), new VkontakeMessagesMailerService()); // Рассыльщик мемом в личку в вк

			List<Mailer> mailers = new List<Mailer> { mailer1, mailer2 };
			foreach (var mailer in mailers)
			{
				mailer.Mail(); // Осуществляем рассылку на всех рассыльщиках
			}
		}
	}
}
