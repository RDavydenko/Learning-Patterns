using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State._002_SmartphoneStates.States
{
	/// <summary>
	/// Состояние готовности
	/// </summary>
	public class ReadyState : StateBase
	{
		public override void ClickLock(Smartphone phone)
		{
			phone.State = new LockedState();
			Console.WriteLine("Смартфон заблокирован");
		}

		public override void CloseApp(Smartphone phone)
		{

		}

		public override void MakePhoneCall(Smartphone phone)
		{
			phone.State = new PhoneCallingState();
			Console.WriteLine("Смартфон в режиме звонка");
		}

		public override void MakePhoto(Smartphone phone)
		{

		}

		public override void OpenCamera(Smartphone phone)
		{
			phone.State = new OpeningCameraState();
			Console.WriteLine("Открыта камера");
		}

		public override void PlayGame(Smartphone phone)
		{
			phone.State = new PlayingGameState();
			Console.WriteLine("Смартфон в игровом режиме");
		}

		public override void PlayMusic(Smartphone phone)
		{
			phone.State = new PlayingMusicState();
			Console.WriteLine("Смартфон в режиме воспроизведения музыки");
		}
	}
}
