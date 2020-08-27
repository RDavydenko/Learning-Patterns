using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy._001_YoutubeServiceProxy.Models
{
	/// <summary>
	/// Информация о видеозаписи
	/// </summary>
	public class VideoInfo
	{
		/// <summary>
		/// Идентификатор ролика
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Название ролика
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Имя автора
		/// </summary>
		public string AuthorName { get; }
		
		/// <summary>
		/// Продолжительность ролика
		/// </summary>
		public TimeSpan Duration { get; }

		/// <summary>
		/// Дата публикации
		/// </summary>
		public DateTime PublicationDate { get; }

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="id">Идентификатор</param>
		/// <param name="name">Название</param>
		/// <param name="authorName">Имя автора</param>
		/// <param name="duration">Длительность</param>
		/// <param name="publicationDate">Дата публикации</param>
		public VideoInfo(int id, string name, string authorName, TimeSpan duration, DateTime publicationDate)
		{
			Id = id;
			Name = name;
			AuthorName = authorName;
			Duration = duration;
			PublicationDate = publicationDate;
		}
	}
}
