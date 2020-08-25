using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bridge._001_CrossPlatformApps.Applications;
using Bridge._001_CrossPlatformApps.Platforms;
using Bridge._002_CustomFigures.Colors;
using Bridge._002_CustomFigures.Figures;

namespace Bridge
{
	class Program
	{
		static void Main(string[] args)
		{
			CrossPlatformApplicationsTest(); // 001
			Console.WriteLine();

			CustomFiguresTest(); // 002
			Console.WriteLine();
		}		

		/// <summary>
		/// Тестируем первый пример реализации паттерна Bridge (мост)
		/// </summary>
		static void CrossPlatformApplicationsTest()
		{
			// Создаем платформы
			var windows = new WindowsPlatform();
			var linux = new LinuxPlatform();
			var mac = new MacOSPlatform();

			// Создаем приложения
			var textEditor = new TextEditor(windows); // Создали текстовый редактор под Windows
			var browser = new Browser(mac); // Запустили браузер под Linux

			Console.WriteLine(textEditor.ToString());	
			Console.WriteLine(browser.ToString());

			Console.WriteLine();

			// Запускаем кросс-платформенные приложения на разных платформах
			windows.DrawApp(browser);
			linux.DrawApp(textEditor);
			mac.DrawApp(textEditor);
		}

		/// <summary>
		/// Тестируем второй пример реализации паттерна Bridge (мост)
		/// </summary>
		static void CustomFiguresTest()
		{
			// Фигуры
			var cube = new Cube(); // Куб
			var sphere = new Sphere(); // Сфера

			Console.WriteLine(cube);
			Console.WriteLine(sphere);
			Console.WriteLine();

			// Цвета
			IColor red = new Red(); // Красный
			IColor yellow = new Yellow(); // Желтый

			// Окрашиваем фигуры
			cube.Color = red;
			sphere.Color = yellow;

			Console.WriteLine(cube);
			Console.WriteLine(sphere);
		}
	}
}
