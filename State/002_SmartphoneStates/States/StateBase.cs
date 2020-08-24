using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State._002_SmartphoneStates.States
{
	/// <summary>
	/// Абстрактный класс состояния телефона
	/// </summary>
	public abstract class StateBase
	{
		/// <summary>
		/// Разблокировать/заблокировать
		/// </summary>
		public abstract void ClickLock(Smartphone phone);

		/// <summary>
		/// Играть музыку
		/// </summary>
		public abstract void PlayMusic(Smartphone phone);

		/// <summary>
		/// Играть в игру
		/// </summary>
		public abstract void PlayGame(Smartphone phone);

		/// <summary>
		/// Сделать телефонный звонок
		/// </summary>
		public abstract void MakePhoneCall(Smartphone phone);

		/// <summary>
		/// Открыть камеру
		/// </summary>
		public abstract void OpenCamera(Smartphone phone);

		/// <summary>
		/// Сделать фото
		/// </summary>
		public abstract void MakePhoto(Smartphone phone);

		/// <summary>
		/// Закрыть/свернуть приложение
		/// </summary>
		public abstract void CloseApp(Smartphone phone);
	}
}
