using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Facade.Attributes;

namespace Facade
{
	/// <summary>
	/// Части тела человека
	/// </summary>
	public enum BodyPart
	{
		[Russifier("Голова")]
		Head = 0,

		[Russifier("Рука")]
		Hand = 1,

		[Russifier("Живот")]
		Paunch = 2,

		[Russifier("Нога")]
		Leg = 3
	}
}
