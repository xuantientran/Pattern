using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior.Visitor
{
	public class PriceVisitor : IVehiculeVisitor
	{
		decimal carTotal = 0;
		decimal bikeTotal = 0;
		public decimal CarTotal => carTotal;
		public decimal BikeTotal => bikeTotal;
		private const int CAR_DISCOUNT = 5;
		private const int BIKE_DISCOUNT = 2;
		/// <summary>
		/// Méhthode pour traiter de l'élément Car
		/// </summary>
		/// <param name="car">élément Car à traité</param>
		public void Visit(Car car)
		{
			decimal carPriceAfterDicount = car.Price - ((car.Price / 100) * CAR_DISCOUNT);
			carTotal += carPriceAfterDicount;
			Console.WriteLine("Car {0} price: {1}", car.CarName, carPriceAfterDicount);
		}

		/// <summary>
		/// Méhthode pour traiter de l'élément Bike
		/// </summary>
		/// <param name="bike">élément Bike à traité</param>
		public void Visit(Bike bike)
		{
			decimal bikePriceAfterDicount = bike.Price - ((bike.Price / 100) * BIKE_DISCOUNT);
			bikeTotal += bikePriceAfterDicount;
			Console.WriteLine("Bike {0} price: {1}", bike.BikeName, bikePriceAfterDicount);
		}
	}
}
