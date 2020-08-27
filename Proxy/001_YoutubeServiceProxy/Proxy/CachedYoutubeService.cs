using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Proxy._001_YoutubeServiceProxy.Models;
using Proxy._001_YoutubeServiceProxy.Service;

namespace Proxy._001_YoutubeServiceProxy.Proxy
{
	/// <summary>
	/// Класс-заместитель (Proxy), кэширующий информацию о видео
	/// </summary>
	public class CachedYoutubeService : IYoutubeService
	{
		/// <summary>
		/// Сервис, предоставляющий информацию о видео
		/// </summary>
		private readonly IYoutubeService _service;

		/// <summary>
		/// Кэш
		/// </summary>
		private List<VideoInfo> _cache;

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="service">Класс, реализующий интерфейс <see cref="IYoutubeService"/></param>
		public CachedYoutubeService(IYoutubeService service)
		{
			_cache = new List<VideoInfo>();
			_service = service;
		}

		public VideoInfo GetVideoInfo(int id)
		{
			var infoFromCache = _cache.FirstOrDefault(x => x.Id == id);
			if (infoFromCache == null) // В кеше нет такой информации
			{
				var info = _service.GetVideoInfo(id);
				_cache.Add(info); // Кэшируем полученные данные
				return info;
			}
			else
			{
				Console.WriteLine("Данные были взяты из кэша для видео с id: " + id);
				return infoFromCache;
			}
		}
	}
}
