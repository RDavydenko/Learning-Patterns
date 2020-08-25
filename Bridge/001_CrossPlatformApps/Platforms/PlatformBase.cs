using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bridge._001_CrossPlatformApps.Applications;

namespace Bridge._001_CrossPlatformApps.Platforms
{
	/// <summary>
	/// Абстрактный класс платформы
	/// </summary>
	public abstract class PlatformBase
	{
		/// <summary>
		/// Название платформы
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="name">Название платформы</param>
		public PlatformBase(string name)
		{
			Name = name;
		}

		/// <summary>
		/// Отрисовать приложение
		/// </summary>
		/// <param name="app">Приложение</param>
		public abstract void DrawApp(ApplicationBase app);
	}
}
