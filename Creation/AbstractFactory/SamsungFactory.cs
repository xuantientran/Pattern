using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.AbstractFactory
{
	// Each Concrete Factory has a corresponding product variant.
	class SamsungFactory : IMobileFactory
	{
		public ISmartPhone CreateSmartPhone() => new SamsungSmartPhone();

		public IBasicPhone CreateBasicPhone() => new SamsungBasicPhone();
	}
}
