using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Memento._001;

namespace Memento
{
	class Program
	{
		static void Main(string[] args)
		{
			MementoTets();
		}

		/// <summary>
		/// Тестируем первый пример реализации паттерна Снимок (Memento)
		/// </summary>
		private static void MementoTets()
		{
			TextEditor textEditor = new TextEditor()
			{
				Width = 1920,
				Height = 1080
			};
			textEditor.AddLine("Hello world!");
			Console.WriteLine("Прежнее состояние:");
			Console.WriteLine(textEditor);
			Console.WriteLine("*************************************************");

			// Делаем снимок
			var memento = textEditor.DoBackup("test");

			// Меняем параметры
			textEditor.AddLine("Go to mars!");
			textEditor.Width = 600;
			textEditor.Height = 600;

			// Восстанавливаем состояние из снимка с именем test
			textEditor.Restore(memento);

			// Проверяем состояние после восстановления
			Console.WriteLine(textEditor);
		}
	}
}
