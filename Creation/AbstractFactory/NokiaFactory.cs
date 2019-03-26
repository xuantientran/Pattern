using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.AbstractFactory
{
	/// <summary>
	/// Concrete Factories produce a family of products that belong to a single variant. The factory guarantees that resulting products are compatible. Note that signatures of the Concrete Factory's methods return an abstract product, while inside the method a concrete product is instantiated.
	/// </summary>
	class NokiaFactory : IMobileFactory
	{
		public ISmartPhone CreateSmartPhone() => new NokiaSmartPhone();

		public IBasicPhone CreateBasicPhone() => new NokiaBasicPhone();
	}
}
