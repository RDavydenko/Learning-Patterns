using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility._001_OnlineShop
{
	/// <summary>
	/// Ответ
	/// </summary>
	public class Response
	{
		/// <summary>
		/// Html-разметка
		/// </summary>
		public string Html { get; private set; }

		/// <summary>
		/// Статусный код
		/// </summary>
		public int StatusCode { get; private set; }

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="html">Html-разметка страницы ответа</param>
		/// <param name="statusCode">Статусный код ответа</param>
		public Response(string html, int statusCode)
		{
			Html = html;
			StatusCode = statusCode;
		}
	}
}
