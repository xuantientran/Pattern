﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Decorator
{
	public class TestDecorator
	{
		public static void Test()
		{
			// Let us create a Simple Cake Base first
			CakeBase cBase = new CakeBase();
			PrintProductDetails(cBase);

			// Lets add cream to the cake
			CreamDecorator creamCake = new CreamDecorator(cBase);
			PrintProductDetails(creamCake);

			// Let now add a Cherry on it
			CherryDecorator cherryCake = new CherryDecorator(creamCake);
			PrintProductDetails(cherryCake);

			// Lets now add Scent to it
			ArtificialScentDecorator scentedCake = new ArtificialScentDecorator(cherryCake);
			PrintProductDetails(scentedCake);

			// Finally add a Name card on the cake
			NameCardDecorator nameCardOnCake = new NameCardDecorator(scentedCake);
			PrintProductDetails(nameCardOnCake);

			// Lets now create a simple Pastry
			PastryBase pastry = new PastryBase();
			PrintProductDetails(pastry);

			// Lets just add cream and cherry only on the pastry 
			CreamDecorator creamPastry = new CreamDecorator(pastry);
			CherryDecorator cherryPastry = new CherryDecorator(creamPastry);
			PrintProductDetails(cherryPastry);
			Console.ReadKey();
		}

		private static void PrintProductDetails(BakeryComponent product)
		{
			Console.WriteLine(); // some whitespace for readability
			Console.WriteLine("Item: {0}, Price: {1}", product.GetName(), product.GetPrice());
		}
	}
}

