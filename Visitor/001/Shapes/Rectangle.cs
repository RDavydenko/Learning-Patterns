using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Visitor._001.Visitors;

namespace Visitor._001.Shapes
{
	/// <summary>
	/// Прямоугольник
	/// </summary>
	public class Rectangle : IVisitable
	{
		public void Accept(IVisitor visitor)
		{
			visitor.VisitRectangle(this);
		}

		public override string ToString()
		{
			return "Прямоугольник";
		}
	}
}
