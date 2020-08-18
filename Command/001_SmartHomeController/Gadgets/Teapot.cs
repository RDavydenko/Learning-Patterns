using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command._001_SmartHomeController.Gadgets
{
	/// <summary>
	/// Чайник
	/// </summary>
	public class Teapot
	{
		/// <summary>
		/// Состояние
		/// </summary>
		public State State { get; private set; } = State.Off;

		/// <summary>
		/// Сменить состояние вкл/выкл
		/// </summary>
		public void ChangeState()
		{
			switch (State)
			{
				case State.Off:
					State = State.On;
					break;
				case State.On:
					State = State.Off;
					break;
			}
		}

		public override string ToString()
		{
			return "Телевизор " + State.ToString();
		}
	}
}
