using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Command._001_SmartHomeController.Gadgets;

namespace Command._001_SmartHomeController.Commands
{
	/// <summary>
	/// Команда, управляющая телевизором
	/// </summary>
	public class TvCommand : ICommand
	{
		private readonly Tv _tv;

		public TvCommand(Tv tv)
		{
			_tv = tv;
		}

		public void Execute()
		{
			_tv.ChangeState();
			Console.WriteLine(_tv);
		}

		public override string ToString()
		{
			if (_tv.State == State.Off)
				return "Включить телевизор";
			else
				return "Выключить телевизор";
		}
	}
}
