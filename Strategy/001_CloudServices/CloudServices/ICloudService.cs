using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy._001_CloudServices.CloudServices
{
	/// <summary>
	/// Интерфейс облачного сервиса
	/// </summary>
	public interface ICloudService
	{
		/// <summary>
		/// Сохранение в облачный сервис
		/// </summary>
		void Save(IList<string> results);
	}
}
