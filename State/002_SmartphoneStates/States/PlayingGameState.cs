using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State._002_SmartphoneStates.States
{
	/// <summary>
	/// Состояние играющего в игру
	/// </summary>
	public class PlayingGameState : StateBase
	{
		public override void ClickLock(Smartphone phone)
		{
			phone.State = new LockedState();
			Console.WriteLine("Смартфон заблокирован");
		}

		public override void CloseApp(Smartphone phone)
		{
			phone.State = new ReadyState();
			Console.WriteLine("Смартфон на главном экране");
		}

		public override void MakePhoneCall(Smartphone phone)
		{
			
		}

		public override void MakePhoto(Smartphone phone)
		{
			
		}

		public override void OpenCamera(Smartphone phone)
		{
			
		}

		public override void PlayGame(Smartphone phone)
		{

		}

		public override void PlayMusic(Smartphone phone)
		{
			
		}
	}
}
