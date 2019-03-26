using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.AbstractFactory
{
	// Concrete Products are created by corresponding Concrete Factories.
	class NokiaSmartPhone : ISmartPhone
	{
		public string Surf() => "NokiaSmartPhone surf";
		public string Call() => "NokiaSmartPhone call";
	}
}
