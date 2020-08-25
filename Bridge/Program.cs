using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bridge._001_CrossPlatformApps.Applications;
using Bridge._001_CrossPlatformApps.Platforms;

namespace Bridge
{
	class Program
	{
		static void Main(string[] args)
		{
			CrossPlatformApplicationsTest(); // 001
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
	}
}
