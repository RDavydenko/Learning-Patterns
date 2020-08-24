using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State._002_SmartphoneStates.States
{
	/// <summary>
	/// Состояние открытой камеры
	/// </summary>
	public class OpeningCameraState : StateBase
	{
		public override void ClickLock(Smartphone phone)
		{
			phone.State = new LockedState();
			Console.WriteLine("Смартфон заблокирован");
		}

		public override void CloseApp(Smartphone phone)
		{
			phone.State = new ReadyState();
			Console.WriteLine("Камера закрыта. Смартфон на главном экране");
		}

		public override void MakePhoneCall(Smartphone phone)
		{
			
		}

		public override void MakePhoto(Smartphone phone)
		{
			Console.WriteLine("Щелк! Сделана фотография");
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
