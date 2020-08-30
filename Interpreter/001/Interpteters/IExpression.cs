using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter._001.Interpteters
{
	/// <summary>
	/// Интерфейс Интерпретатора
	/// </summary>
	public interface IExpression
	{
		/// <summary>
		/// Интерпретировать контекст
		/// </summary>
		/// <param name="context">Контекст</param>
		/// <returns>Результат</returns>
		int Interpret(Context context);
	}
}
