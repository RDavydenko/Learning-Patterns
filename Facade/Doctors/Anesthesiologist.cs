using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Doctors
{
	/// <summary>
	/// Анастезиолог
	/// </summary>
	public class Anesthesiologist
	{
		/// <summary>
		/// Сделать анестезию
		/// </summary>
		/// <param name="anesthesiaType">Тип анастезии</param>
		public void DoAnaesthetic(AnesthesiaType anesthesiaType)
		{
			switch (anesthesiaType)
			{
				case AnesthesiaType.Spinal:
					Console.WriteLine("Анестезиолог: применил спинную анестезию");
					break;
				case AnesthesiaType.Local:
					Console.WriteLine("Анестезиолог: применил местную анестезию");
					break;
				case AnesthesiaType.Narcosis:
					Console.WriteLine("Анестезиолог: применил общий наркоз");
					break;
			}
		}


		/// <summary>
		/// Тип анастезии
		/// </summary>
		public enum AnesthesiaType
		{
			/// <summary>
			/// Спинная
			/// </summary>
			Spinal = 0,

			/// <summary>
			/// Местная
			/// </summary>
			Local = 1,

			/// <summary>
			/// Общий наркоз
			/// </summary>
			Narcosis = 2
		}
	}
}
