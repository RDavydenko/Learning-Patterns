using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility._001_OnlineShop.Handlers
{
	/// <summary>
	/// Обработчик доступности
	/// </summary>
	public class AvailableHandler : HandlerBase
	{
		/// <summary>
		/// Репозиторий, хранящий информацию о наличии товара
		/// </summary>
		private Dictionary<string, int> _repository = new Dictionary<string, int>
		{
			{"картошка", 20 },
			{ "мука", 1 },
			{ "рис", 3 },
			{ "икра", 4 },
			{ "помидоры", 0 },
			{ "огурцы", 0 },
		};

		public AvailableHandler(HandlerBase next) : base(next)
		{
		}

		public async override Task InvokeAsync(Context context)
		{
			var url = context.Request.Url.ToLower();
			var query = url.Split('?')[1] ?? string.Empty;
			var pairs = query.Split('&');
			List<Tuple<string, string>> keyValuePairs = new List<Tuple<string, string>>();
			foreach (var pair in pairs)
			{
				var param = pair.Split('=')[0];
				var value = pair.Split('=')[1];
				if (!keyValuePairs.Any(x => x.Item1 == param))
				{
					keyValuePairs.Add(new Tuple<string, string>(param, value));
				}
			}

			var productName = keyValuePairs.Where(x => x.Item1 == "product").Select(x => x.Item2).FirstOrDefault();
			var productValue = keyValuePairs.Where(x => x.Item1 == "value").Select(x => x.Item2).FirstOrDefault();
			int valueInt;
			bool parsed = int.TryParse(productValue, out valueInt);

			if(parsed == false)
			{
				context.SetResponse(new Response("Неправильно введено количество товара", 403));
				return;
			}

			if (productName != null && _repository.ContainsKey(productName))
			{
				var productCount = _repository[productName];
				if (productCount >= valueInt)
				{
					await Next?.InvokeAsync(context);
				}
				else
				{
					context.SetResponse(new Response("Нет достаточного количества товара", 200));
					return;
				}
			}
			else
			{
				context.SetResponse(new Response("Данного товара нет и не было на складе", 403));
				return;
			}
		}
	}
}
