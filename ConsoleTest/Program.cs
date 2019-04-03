using Behavior.ChainResponsibility;
using Behavior.Command;
using Behavior.CommandSimple;
using Behavior.Visitor;
using Creation.AbstractFactory;
using Creation.Builder;
using Creation.Factory;
using Lib;
using Structure.Decorator;
using System;
using System.Collections.Generic;
using System.IO;
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
			//new Client().Test();
			//TestDecorator.Test();
			//string path = Path.Combine(Utility.GetDataDirectory(), "V01X13.Tree.txt");
			//Tree tree = new Tree(path);
			//tree.Load();
			//TestChainResponsibility.Test();
			TestCommand.Test();
			//TestCommandSimple.TestMedia();
			Console.ReadKey();
		}
	}
}
