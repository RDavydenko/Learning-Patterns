using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Proxy._001_YoutubeServiceProxy.Models;

namespace Proxy._001_YoutubeServiceProxy.Service
{
	/// <summary>
	/// API Ютуба
	/// </summary>
	public class YotubeServiceApi : IYoutubeService
	{
		private Random _rnd = new Random();

		public VideoInfo GetVideoInfo(int id)
		{
			Console.WriteLine("Обращение к API Youtube для получения информации о видео с id: " + id);

			var names = new List<string>
			{
				"Приколы", "Пранки", "Новости", "Авто", "Блог"
			};
			var authorNames = new List<string>
			{
				"Егор", "Юра", "Виталий", "Евгений", "Виктория"
			};
			var durations = new List<TimeSpan>
			{
				new TimeSpan(0,10,20),
				new TimeSpan(1,00,5),
				new TimeSpan(0,2,59),
				new TimeSpan(0,21,0),
				new TimeSpan(0,4,37)
			};
			var publicationDates = new List<DateTime>
			{
				DateTime.Now,
				DateTime.Now - TimeSpan.FromDays(10),
				DateTime.Now - TimeSpan.FromHours(3),
				new DateTime(2019,10,2)
			};
			return new VideoInfo(
				id: id,
				name: names[_rnd.Next(names.Count)],
				authorName: authorNames[_rnd.Next(authorNames.Count)],
				duration: durations[_rnd.Next(durations.Count)],
				publicationDate: publicationDates[_rnd.Next(publicationDates.Count)]
				);
		}
	}
}
