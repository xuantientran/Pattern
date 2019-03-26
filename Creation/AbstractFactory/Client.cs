using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.AbstractFactory
{
	/// <summary>
	/// The client code works with factories and products only through abstract types: AbstractFactory and AbstractProduct. This lets you pass any factory or product subclass to the client code without breaking it.
	/// </summary>
	public class Client
	{
		public void Test()
		{
			// The client code can work with any concrete factory class.
			Console.WriteLine("Testing NokiaFactory et SamsungFactory");
			ClientMethod(new NokiaFactory(), new SamsungFactory());
			Console.WriteLine();
		}

		public void ClientMethod(IMobileFactory factory, IMobileFactory factory2)
		{
			var smart = factory2.CreateSmartPhone();
			var basic = factory.CreateBasicPhone();

			Console.WriteLine(basic.Call());
			Console.WriteLine(basic.ReceiveSmartPhoneCall(smart));
		}
	}
}
