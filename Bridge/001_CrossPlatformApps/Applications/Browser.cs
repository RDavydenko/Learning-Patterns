using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bridge._001_CrossPlatformApps.Platforms;

namespace Bridge._001_CrossPlatformApps.Applications
{
	/// <summary>
	/// Кроссплатформенный браузер
	/// </summary>
	public class Browser : ApplicationBase
	{
		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="platform">Платформа</param>
		public Browser(PlatformBase platform) : base("Браузер", platform)
		{

		}

		public override string ToString()
		{
			return $"{Name} на платформе {Platform.Name}";
		}
	}
}
