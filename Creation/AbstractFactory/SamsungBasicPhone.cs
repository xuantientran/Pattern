using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.AbstractFactory
{
	class SamsungBasicPhone : IBasicPhone
	{
		public string Call() => "SamsungBasicPhone call";

		public string ReceiveCall() => "SamsungBasicPhone receive call";

		// The variant, Product B2, is only able to work correctly with the
		// variant, Product A2. Nevertheless, it accepts any instance of
		// AbstractProductA as an argument.
		public string ReceiveSmartPhoneCall(ISmartPhone collaborator) =>
			"SamsungBasicPhone receive " + collaborator.Call();
	}
}
