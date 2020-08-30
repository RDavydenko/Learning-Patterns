using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter._001.Interpteters
{
	/// <summary>
	/// Вычитание
	/// </summary>
	public class SubtractExpression : IExpression
	{
		private readonly IExpression _left;
		private readonly IExpression _right;

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="left">Левое выражение</param>
		/// <param name="right">Правое выражение</param>
		public SubtractExpression(IExpression left, IExpression right)
		{
			_left = left;
			_right = right;			
		}

		public int Interpret(Context context)
		{
			// Вычитаем
			return _left.Interpret(context) - _right.Interpret(context);
		}
	}
}
