using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Command._001_SmartHomeController.Gadgets;

namespace Command._001_SmartHomeController.Commands
{
	/// <summary>
	/// Команда, управляющая светом
	/// </summary>
	public class LightCommand : ICommand
	{
		private readonly Light _light;

		public LightCommand(Light light)
		{
			_light = light;
		}

		public void Execute()
		{
			_light.ChangeState();
			Console.WriteLine(_light);
		}

		public override string ToString()
		{
			if (_light.State == State.Off)
				return "Включить освещение";
			else
				return "Выключить освещение";
		}
	}
}
