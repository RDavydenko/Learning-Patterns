using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility._001_OnlineShop.Handlers
{
	/// <summary>
	/// Завершающий обработчик
	/// </summary>
	public class EndHandler : HandlerBase
	{
		public EndHandler(HandlerBase next = null) : base(next)
		{
		}

		public override Task InvokeAsync(Context context)
		{
			context.SetResponse(new Response("Обработка запроса прошла успешно", 200));

			return Task.CompletedTask;
		}
	}
}
