using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.AbstractFactory
{
	class SamsungSmartPhone : ISmartPhone
	{
		public string Surf() => "SamsungSmartPhone surf";
		public string Call() => "SamsungSmartPhone call";
	}
}
