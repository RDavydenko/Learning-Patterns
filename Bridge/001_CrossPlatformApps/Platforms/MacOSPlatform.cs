using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bridge._001_CrossPlatformApps.Applications;

namespace Bridge._001_CrossPlatformApps.Platforms
{
	public class MacOSPlatform : PlatformBase
	{
		public MacOSPlatform()
			: base("MacOS")
		{

		}

		public override void DrawApp(ApplicationBase app)
		{
			Console.WriteLine($"Запустили приложение {app.Name} на платформе {Name}");
		}
	}
}
