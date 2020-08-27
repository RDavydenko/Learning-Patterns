using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Proxy._001_YoutubeServiceProxy.Models;

namespace Proxy._001_YoutubeServiceProxy.Service
{
	/// <summary>
	/// Интерфейс сервиса Ютуба
	/// </summary>
	public interface IYoutubeService
	{
		/// <summary>
		/// Возвращает информацию о видеозаписи
		/// </summary>
		/// <param name="id">Идентификатор видеозаписи</param>
		/// <returns>Информация о видеозаписи</returns>
		VideoInfo GetVideoInfo(int id);
	}
}
