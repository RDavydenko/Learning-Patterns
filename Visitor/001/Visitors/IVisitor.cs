using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Visitor._001.Shapes;

namespace Visitor._001.Visitors
{
	/// <summary>
	/// Интерфейс постетителя
	/// </summary>
	public interface IVisitor
	{
		/// <summary>
		/// Посетить точку
		/// </summary>
		/// <param name="dot">Точка</param>
		void VisitDot(Dot dot);

		/// <summary>
		/// Посетить круг
		/// </summary>
		/// <param name="circle">Круг</param>
		void VisitCircle(Circle circle);

		/// <summary>
		/// Посетить прямоугольник
		/// </summary>
		/// <param name="rectangle">Прямоугольник</param>
		void VisitRectangle(Rectangle rectangle);
	}
}
