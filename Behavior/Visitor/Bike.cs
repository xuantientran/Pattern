using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior
{
	public class Bike : IStore
	{
		public string BikeName { get; set; }
		public decimal Price { get; set; }
		public string BikeType { get; set; }

		public void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
