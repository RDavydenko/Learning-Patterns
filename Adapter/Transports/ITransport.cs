using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Transports
{
	/// <summary>
	/// Интерфейс транспорта
	/// </summary>
	public interface ITransport
	{
		/// <summary>
		/// Водить транспорт
		/// </summary>
		void Drive();
	}
}
