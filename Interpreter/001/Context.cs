using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter._001
{
	public class Context
	{
		Dictionary<string, int> _variables;

		public Context()
		{
			_variables = new Dictionary<string, int>();
		}

		public void SetVariable(string name, int value)
		{
			if (_variables.ContainsKey(name) == false)
			{
				_variables.Add(name, value);
			}
			else
			{
				throw new ArgumentException("", nameof(name));
			}
		}

		public int GetVariable(string name)
		{
			if (_variables.ContainsKey(name))
			{
				return _variables[name];
			}
			else
			{
				throw new ArgumentException("message", nameof(name));
			}
		}

		public bool HasVariable(string name)
		{
			return _variables.ContainsKey(name);
		}
	}
}
