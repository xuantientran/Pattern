using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Decorator
{
	/// <summary>
	/// Component interface
	/// </summary>
	public abstract class BakeryComponent
	{
		public abstract string GetName();
		public abstract double GetPrice();
	}
}
