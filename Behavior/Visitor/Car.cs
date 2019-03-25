using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior
{
	public class Car : IStore
	{
		public string CarName { get; set; }
		public decimal Price { get; set; }
		public string CarType { get; set; }

		public void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
