using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior
{
	public class TestVisitor
	{
		public static void Test()
		{
			List<IStore> store = new List<IStore>();
			store.Add(new Car() { CarName = "A1", Price = 200M, CarType = "Mercedes" });
			store.Add(new Car() { CarName = "A2", Price = 100M, CarType = "Normal" });

			store.Add(new Bike() { BikeName = "B1", Price = 50M, BikeType = "Bullet" });
			store.Add(new Bike() { BikeName = "B2", Price = 30M, BikeType = "Normal" });

			//Show price of each item
			PriceVisitor priceVisitor = new PriceVisitor();
			foreach (var element in store)
			{
				element.Accept(priceVisitor);
			}

			//Show weight of each item
			WeightVisitor weightVisitor = new WeightVisitor();
			foreach (var element in store)
			{
				element.Accept(weightVisitor);
			}

		}
	}
}
