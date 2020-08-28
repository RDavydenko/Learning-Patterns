using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility._001_OnlineShop.Handlers
{
	/// <summary>
	/// Валидатор корректности запроса
	/// </summary>
	public class QueryHandler : HandlerBase
	{
		public QueryHandler(HandlerBase next) : base(next)
		{
		}

		public async override Task InvokeAsync(Context context)
		{
			var url = context.Request.Url;
			if (url.ToLower().StartsWith("shop.com"))
			{
				await Next?.InvokeAsync(context);
			}
			else
			{
				context.SetResponse(new Response("Неверный адрес запроса", 404));
				return;
			}
		}
	}
}
