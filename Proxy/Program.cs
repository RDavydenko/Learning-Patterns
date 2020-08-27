using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Proxy._001_YoutubeServiceProxy.Proxy;
using Proxy._001_YoutubeServiceProxy.Service;

namespace Proxy
{
	class Program
	{
		static void Main(string[] args)
		{
			YoutubeServiceProxyTest(); // 001
		}

		/// <summary>
		/// Тестируем первый пример реализации паттерна Proxy (Заместитель).
		/// В данном случае добавляет кэширование.
		/// </summary>
		private static void YoutubeServiceProxyTest()
		{
			IYoutubeService youtubeService = new YotubeServiceApi(); // Youtube-сервис 
			IYoutubeService cachedYoutubeService = new CachedYoutubeService(youtubeService); // Заместитель Youtube-сервиса. Добавляет кэширование

			// Обращаемся для получения информации о видео
			var info1 = cachedYoutubeService.GetVideoInfo(2); // Из API
			var info2 = cachedYoutubeService.GetVideoInfo(1); // Из API
			var info3 = cachedYoutubeService.GetVideoInfo(1); // Из кэша
		}
	}
}
