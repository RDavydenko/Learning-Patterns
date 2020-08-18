using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command._001_SmartHomeController.Commands
{
	/// <summary>
	/// Интерфейс команды
	/// </summary>
	public interface ICommand
	{
		/// <summary>
		/// Вызов команды
		/// </summary>
		void Execute();
	}
}
