using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility._001_OnlineShop
{
	/// <summary>
	/// Контекст (запрос + ответ)
	/// </summary>
	public class Context
	{
		/// <summary>
		/// Запрос
		/// </summary>
		public Request Request { get; }

		/// <summary>
		/// Ответ
		/// </summary>
		public Response Response { get; private set; }

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="request">Запрос</param>
		public Context(Request request)
		{
			Request = request;
		}

		/// <summary>
		/// Установить ответ <see cref="_001_OnlineShop.Response"/>
		/// </summary>
		/// <param name="response">Ответ</param>
		/// <exception cref="ArgumentNullException">Если <paramref name="response"/> является null</exception>
		public void SetResponse(Response response)
		{
			if (response is null)
			{
				throw new ArgumentNullException(nameof(response));
			}
			Response = response;
		}
	}
}
