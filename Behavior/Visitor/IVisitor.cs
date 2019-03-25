using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior
{
	public interface IVisitor
	{
		void Visit(Car car);
		void Visit(Bike bike);
	}
}
