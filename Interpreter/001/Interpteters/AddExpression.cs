using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter._001.Interpteters
{
	/// <summary>
	/// Сложение
	/// </summary>
	public class AddExpression : IExpression
	{
		private readonly IExpression _left;
		private readonly IExpression _right;

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="left">Левое выражение</param>
		/// <param name="right">Правое выражение</param>
		public AddExpression(IExpression left, IExpression right)
		{
			_left = left;
			_right = right;
		}

		public int Interpret(Context context)
		{
			// Выполняем сложение
			return _left.Interpret(context) + _right.Interpret(context);
		}
	}
}
