using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Visitor._001.Shapes;

namespace Visitor._001.Visitors
{
	/// <summary>
	/// Посетитель
	/// </summary>
	public class Visitor : IVisitor
	{
		public void VisitCircle(Circle circle)
		{
			Console.WriteLine("Посетили фигуру: " + circle);
		}

		public void VisitDot(Dot dot)
		{
			Console.WriteLine("Посетили фигуру: " + dot);
		}

		public void VisitRectangle(Rectangle rectangle)
		{
			Console.WriteLine("Посетили фигуру: " + rectangle);
		}
	}
}
