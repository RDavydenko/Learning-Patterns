using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using State._001_WaterStates;
using State._001_WaterStates.States;
using State._002_SmartphoneStates;

namespace State
{
	class Program
	{
		static void Main(string[] args)
		{
			WaterStatesTest(); // 001
			Console.WriteLine();

			SmartphoneStatesTest(); // 002
		}

		/// <summary>
		/// Тестируем первый пример паттерна Состояние
		/// </summary>
		private static void WaterStatesTest()
		{
			Water water = new Water(new SteamWaterState()); // Вода в газообразном состоянии
			water.Cool(); // Охлаждаем: газ → жидкость
			water.Cool(); // Охлаждаем: жидкость → твердое
			water.Cool(); // Охлаждаем: твердое → твердое (без изменений)
			water.Heat(); // Нагреваем: твердое → жидкость
			water.Cool(); // Охлаждаем: жидкость → твердое
			water.Heat(); // Нагреваем: твердое → жидкость
			water.Heat(); // Нагреваем: жидкость → газ
			water.Heat(); // Нагреваем: газ → газ (без изменений)
			water.Cool(); // Охлаждаем: газ → жидкость
		}

		/// <summary>
		/// Тестируем второй пример паттерна Состояние
		/// </summary>
		private static void SmartphoneStatesTest()
		{
			Smartphone phone = new Smartphone(); // Телефон
			var commands = phone.GetCommands(); // Список доступных команд

			// Формируем "пульт"
			var sb = new StringBuilder();
			for (int i = 0; i < commands.Count; i++)
			{
				sb.AppendLine($"{i + 1}: {commands[i]}");
			}
			Console.Write(sb.ToString()); // Отображаем пульт
			Console.WriteLine("Для использования команды нажмите клавишу");

			while (true)
			{
				var ch = Console.ReadKey(true).KeyChar;
				Click(ch.ToString());
			}

			void Click(string command) // Вызов команды в зависимости от нажатой клавиши
			{
				switch (command)
				{
					case "1":
						phone.ClickLock();
						break;
					case "2":
						phone.CloseApp();
						break;
					case "3":
						phone.MakePhoneCall();
						break;
					case "4":
						phone.OpenCamera();
						break;
					case "5":
						phone.MakePhoto();
						break;
					case "6":
						phone.PlayGame();
						break;
					case "7":
						phone.PlayMusic();
						break;
					default:
						break;
				}
			}
		}
	}
}
