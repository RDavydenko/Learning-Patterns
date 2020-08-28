using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento._001
{
	/// <summary>
	/// Интерфейс снимка
	/// </summary>
	public interface IMemento
	{
		/// <summary>
		/// Возвращает название снимка
		/// </summary>
		/// <returns>Название снимка</returns>
		string GetName();

		/// <summary>
		/// Возвращает дату создания снимка
		/// </summary>
		/// <returns>Дата создания снимка</returns>
		DateTime GetDate();

		/// <summary>
		/// Возвращает состояние объекта <see cref="TextEditor"/> во время снимка
		/// </summary>
		/// <returns>Состояние объекта <see cref="TextEditor"/> во время снимка</returns>
		TextEditor GetBackup();
	}
}
