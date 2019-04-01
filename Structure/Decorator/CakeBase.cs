﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Decorator
{
	//ConcreteComponent
	class CakeBase : BakeryComponent
	{
		// In real world these values will typically come from some data store
		private string m_Name = "Cake Base";
		private double m_Price = 200.0;

		public override string GetName()
		{
			return m_Name;
		}

		public override double GetPrice()
		{
			return m_Price;
		}
	}
}