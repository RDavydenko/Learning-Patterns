using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility._001_OnlineShop
{
	/// <summary>
	/// Запрос
	/// </summary>
	public class Request
	{
		/// <summary>
		/// Ссылка
		/// </summary>
		public string Url { get; private set; }

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="url">Ссылка</param>
		public Request(string url)
		{
			Url = url;
		}
	}
}
