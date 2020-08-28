using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Visitor._001.Visitors;

namespace Visitor._001.Shapes
{
	/// <summary>
	/// Круг
	/// </summary>
	public class Circle : IVisitable
	{
		public void Accept(IVisitor visitor)
		{
			visitor.VisitCircle(this);
		}

		public override string ToString()
		{
			return "Круг";
		}
	}
}
