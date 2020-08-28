using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Visitor._001.Visitors;

namespace Visitor._001.Shapes
{
	/// <summary>
	/// Точка
	/// </summary>
	public class Dot : IVisitable
	{
		public void Accept(IVisitor visitor)
		{
			visitor.VisitDot(this);
		}

		public override string ToString()
		{
			return "Точка";
		}
	}
}
