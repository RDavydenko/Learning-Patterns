using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using State._002_SmartphoneStates.States;

namespace State._002_SmartphoneStates
{
	/// <summary>
	/// Смартфон
	/// </summary>
	public class Smartphone
	{
		/// <summary>
		/// Текущее состояние телефона
		/// </summary>
		public StateBase State { get; set; } = new LockedState();

		/// <summary>
		/// Нажать на кнопку блокировки
		/// </summary>
		public void ClickLock()
		{
			State.ClickLock(this);
		}

		/// <summary>
		/// Нажать на кнопку "Закрыть приложение"
		/// </summary>
		public void CloseApp()
		{
			State.CloseApp(this);
		}

		/// <summary>
		/// Совершить телефонный звонок
		/// </summary>
		public void MakePhoneCall()
		{
			State.MakePhoneCall(this);
		}

		/// <summary>
		/// Открыть камеру
		/// </summary>
		public void OpenCamera()
		{
			State.OpenCamera(this);
		}

		/// <summary>
		/// Сделать фотографию
		/// </summary>
		public void MakePhoto()
		{
			State.MakePhoto(this);
		}

		/// <summary>
		/// Играть в игру
		/// </summary>
		public void PlayGame()
		{
			State.PlayGame(this);
		}

		/// <summary>
		/// Воспроизводить музыку
		/// </summary>
		public void PlayMusic()
		{
			State.PlayMusic(this);
		}

		public List<string> GetCommands()
		{
			var commands = new List<string>
			{
				"Нажать кнопку блокировки",
				"Нажать на кнопку \"Закрыть приложение\"",
				"Совершить телефонный звонок",
				"Открыть камеру",
				"Сделать фотографию",
				"Играть в игру",
				"Воспроизводить музыку"
			};
			return commands;
		}
	}
}
