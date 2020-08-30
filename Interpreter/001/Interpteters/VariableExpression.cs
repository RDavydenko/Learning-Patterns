using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter._001.Interpteters
{
	/// <summary>
	/// Переменная
	/// </summary>
	public class VariableExpression : IExpression
	{
		private readonly string _name;

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="name">Название переменной</param>
		public VariableExpression(string name)
		{
			_name = name;
		}

		public int Interpret(Context context)
		{
			if (context.HasVariable(_name))
			{
				return context.GetVariable(_name);
			}
			throw new ArgumentException("", nameof(context));
		}
	}
}
