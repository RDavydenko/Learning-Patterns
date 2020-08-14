using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer._002_EventOrientedObservers.Observers
{
	/// <summary>
	/// МЧС
	/// </summary>
	public class Emercom
	{
		public void SendSMS(string location, double degrees, string weatherPattern)
		{
			if (weatherPattern == "Град" 
				|| weatherPattern == "Ливень"
				|| weatherPattern == "Ураган"
				|| weatherPattern == "Метель")
			{
				// Рассылаем предупреждающие сообщения пользователям 

				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"!!! МЧС предупреждает: В городе {location} возможен {weatherPattern}. Температура: {degrees}");
				Console.ResetColor();
			}
		}
	}
}
