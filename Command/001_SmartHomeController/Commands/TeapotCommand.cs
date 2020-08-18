using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Command._001_SmartHomeController.Gadgets;

namespace Command._001_SmartHomeController.Commands
{
	/// <summary>
	/// Команда, управляющая чайником
	/// </summary>
	public class TeapotCommand : ICommand
	{
		private readonly Teapot _teapot;

		public TeapotCommand(Teapot tv)
		{
			_teapot = tv;
		}

		public void Execute()
		{
			_teapot.ChangeState();
			Console.WriteLine(_teapot);
		}

		public override string ToString()
		{
			if (_teapot.State == State.Off)
				return "Включить чайник";
			else
				return "Выключить чайник";
		}
	}
}
