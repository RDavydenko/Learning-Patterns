using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Command._001_SmartHomeController;
using Command._001_SmartHomeController.Commands;
using Command._001_SmartHomeController.Gadgets;

namespace Command
{
	class Program
	{
		static void Main(string[] args)
		{
			HomeController homeController = new HomeController();
			homeController.AddCommand("1", new LightCommand(new Light()));
			homeController.AddCommand("2", new TvCommand(new Tv()));
			homeController.AddCommand("3", new TeapotCommand(new Teapot()));

			string next = string.Empty;
			do
			{
				Console.Clear();
				Console.WriteLine("Список доступных команд:");
				Console.WriteLine(homeController.ToString());
				Console.Write("Введите номер команды: ");
				string number = Console.ReadLine().Trim();
				if (number != null)
				{
					homeController.ExecuteCommand(number);
				}

				while (next != "y" && next != "n")
				{
					Console.Write("Продолжить? (y/n): ");
					next = Console.ReadLine().ToLower();
				}

			} while (next == "y" && next != "n");
		}
	}
}
