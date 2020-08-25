using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bridge._001_CrossPlatformApps.Platforms;

namespace Bridge._001_CrossPlatformApps.Applications
{
	/// <summary>
	/// Абстрактный класс приложения
	/// </summary>
	public abstract class ApplicationBase
	{
		/// <summary>
		/// Название приложения
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Платформа, на которой работает приложение
		/// </summary>
		public PlatformBase Platform { get; }

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="name">Название приложения</param>
		/// <param name="platform">Платформа</param>
		public ApplicationBase(string name, PlatformBase platform)
		{
			Name = name;
			Platform = platform;
		}
	}
}
