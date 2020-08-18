using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Command._001_SmartHomeController.Commands;

namespace Command._001_SmartHomeController
{
	/// <summary>
	/// Управление умным домом
	/// </summary>
	public class HomeController 
	{
		/// <summary>
		/// Словарь команд
		/// </summary>
		private Dictionary<string, ICommand> _commands = new Dictionary<string, ICommand>();

		/// <summary>
		/// Добавить команду
		/// </summary>
		/// <param name="key">Ключ</param>
		/// <param name="command">Команда</param>
		public void AddCommand(string key, ICommand command)
		{
			_commands.Add(key, command);
		}

		/// <summary>
		/// Вызвать команду по ключу
		/// </summary>
		/// <param name="key">Ключ</param>
		public void ExecuteCommand(string key)
		{
			if (_commands.ContainsKey(key))
			{
				_commands[key].Execute();
			}
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			foreach (var pair in _commands)
			{
				sb.AppendLine($"{pair.Key}. {pair.Value}");
			}
			return sb.ToString();
		}
	}
}
