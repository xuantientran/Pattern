using Behavior.Visitor;
using Creation.AbstractFactory;
using Creation.Builder;
using Creation.Factory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTest
{
	class Program
	{
		static void Main(string[] args)
		{
			//TestVisitor.Test();
			//TestAbstractFactory.Test();
			//TestFactory.Test();
			//TestBuilder.Test();
			new Client().Test();
			Console.ReadKey();
		}
	}
}
