using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Decorator
{
	class CherryDecorator : Decorator
	{
		public CherryDecorator(BakeryComponent baseComponent)
				: base(baseComponent)
		{
			this.m_Name = "Cherry";
			this.m_Price = 2.0;
		}
	}
}
