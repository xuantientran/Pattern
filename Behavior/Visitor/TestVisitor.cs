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
			//On crée une structure des éléments
			var store = CreateStore();

			//Le visitor qui se charge du traitement de prix pour chaque élément.
			PriceVisitor priceVisitor = new PriceVisitor();

			//La méthode Accept d'un élément appelle la méthode Visit du Visitor qui prend en paramètre l'élément.
			//On doit déclencher ce mécanisme chaque fois qu'on arrive à un élément en appelant sa méthode Accept
			foreach (var element in store)
				element.Accept(priceVisitor);

			//Idem pour WeightVisitor
			WeightVisitor weightVisitor = new WeightVisitor();
			foreach (var element in store)
				element.Accept(weightVisitor);

			Console.WriteLine("Bike total : " + priceVisitor.BikeTotal);
			Console.WriteLine("Car total : " + priceVisitor.CarTotal);

			Console.WriteLine("Bike total weight: " + weightVisitor.BikeTotalWeitht);
			Console.WriteLine("Car total weight: " + weightVisitor.CarTotalWeight);
		}

		public static List<IStore> CreateStore()
		{
			List<IStore> store = new List<IStore>();
			store.Add(new Car() { CarName = "A1", Price = 200M, CarType = "Mercedes", Weight = 1750 });
			store.Add(new Car() { CarName = "A2", Price = 100M, CarType = "Normal", Weight = 1750 });

			store.Add(new Bike() { BikeName = "B1", Price = 50M, BikeType = "Bullet", Weight = 750 });
			store.Add(new Bike() { BikeName = "B2", Price = 30M, BikeType = "Normal", Weight = 750 });
			return store;
		}

	}
}
