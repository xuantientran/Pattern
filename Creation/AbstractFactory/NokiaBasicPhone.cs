using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.AbstractFactory
{
	// Concrete Products are created by corresponding Concrete Factories.
	class NokiaBasicPhone : IBasicPhone
	{
		public string Call() => "NokiaBasicPhone call";

		public string ReceiveCall() => "NokiaBasicPhone receive call";

		// The variant, Product B1, is only able to work correctly with the
		// variant, Product A1. Nevertheless, it accepts any instance of
		// AbstractProductA as an argument.
		public string ReceiveSmartPhoneCall(ISmartPhone collaborator) =>
			"NokiaBasicPhone receive " + collaborator.Call();
	}
}
