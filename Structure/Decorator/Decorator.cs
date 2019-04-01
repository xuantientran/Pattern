using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Decorator
{
	public abstract class Decorator : BakeryComponent
	{
		BakeryComponent m_BaseComponent = null;

		protected string m_Name = "Undefined Decorator";
		protected double m_Price = 0.0;

		protected Decorator(BakeryComponent baseComponent)
		{
			m_BaseComponent = baseComponent;
		}

		//BakeryComponent Members

		public override string GetName()
		{
			return string.Format("{0}, {1}", m_BaseComponent.GetName(), m_Name);
		}

		public override double GetPrice()
		{
			return m_Price + m_BaseComponent.GetPrice();
		}
	}
}
