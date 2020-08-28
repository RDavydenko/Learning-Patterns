using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChainOfResponsibility._001_OnlineShop;
using ChainOfResponsibility._001_OnlineShop.Handlers;

namespace ChainOfResponsibility
{
	class Program
	{
		static void Main(string[] args)
		{
			OnlineShopTest(); // 001
		}

		/// <summary>
		/// Тестируем первый пример реализации паттерна Цепочка обязанностей (Chain of Responsibility)
		/// </summary>
		private static void OnlineShopTest()
		{
			// Создаем конвейер обработки запроса
			HandlerBase endHandler = new EndHandler();
			HandlerBase availableHandler = new AvailableHandler(endHandler);
			HandlerBase queryHandler = new QueryHandler(availableHandler);
			/* Сначала срабатывает обработчик строки запроса (queryHandler), затем обработчик доступности товара на складе (availableHandler),
			 * затем последний обработчик, который завершает конвейер обработки (endHandler) */

			var context = new Context(new Request("shop.com?product=картошка&value=s")); // Создаем запрос

			queryHandler.InvokeAsync(context).Wait(); // Начинаем обработку запроса с первого обработчика

			Console.WriteLine($"{context.Response.Html}\nСтатусный код: {context.Response.StatusCode}"); // Вывод ответа
		}
	}
}
