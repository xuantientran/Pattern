using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.AbstractFactory
{
	/// <summary>
	/// Each distinct product of a product family should have a base interface. All variants of the product must implement this interface.
	/// </summary>
	public interface ISmartPhone
	{
		string Surf();
		string Call();
	}
}
