using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter._001.Interpteters
{
	/// <summary>
	/// Константа
	/// </summary>
	public class ConstantExpression : IExpression
	{
		private readonly int _value;

		public ConstantExpression(int value)
		{
			_value = value;
		}

		public int Interpret(Context context)
		{
			return _value;
		}
	}
}
