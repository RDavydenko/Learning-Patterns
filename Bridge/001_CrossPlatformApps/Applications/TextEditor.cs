using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bridge._001_CrossPlatformApps.Platforms;

namespace Bridge._001_CrossPlatformApps.Applications
{
	/// <summary>
	/// Текстовый редактор
	/// </summary>
	public class TextEditor : ApplicationBase
	{
		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="platform">Платформа</param>
		public TextEditor(PlatformBase platform) : base("Текстовый редактор", platform)
		{

		}

		public override string ToString()
		{
			return $"{Name} на платформе {Platform.Name}";
		}
	}
}
