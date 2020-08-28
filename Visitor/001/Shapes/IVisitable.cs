using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Visitor._001.Visitors;

namespace Visitor._001.Shapes
{
	public interface IVisitable
	{
		void Accept(IVisitor visitor);
	}
}
