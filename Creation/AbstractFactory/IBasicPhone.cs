using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.AbstractFactory
{
	/// <summary>
	/// Here's the the base interface of another product. All products can interact with each other, but proper interaction is possible only between products of the same concrete variant.
	/// </summary>
	public interface IBasicPhone
	{
		// Product B is able to do its own thing...
		string Call();
		string ReceiveCall();

		// ...but it also can collaborate with the ProductA.
		//
		// The Abstract Factory makes sure that all products it creates are of
		// the same variant and thus, compatible.
		string ReceiveSmartPhoneCall(ISmartPhone collaborator);
	}
}
