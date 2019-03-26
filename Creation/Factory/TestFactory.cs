using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.Factory
{
	public class TestFactory
	{
		public static void Test()
		{
			CardFactory factory = null;
			Console.WriteLine("Enter the card type you would like get: ");
			Console.WriteLine("1 for moneyback");
			Console.WriteLine("2 for titanium");
			Console.WriteLine("3 for platinum");
			string car = Console.ReadLine();

			switch (car.ToLower())
			{
				case "1":
					factory = new MoneyBackFactory(50000, 0);
					break;
				case "2":
					factory = new TitaniumFactory(100000, 500);
					break;
				case "3":
					factory = new PlatinumFactory(500000, 1000);
					break;
				default:
					break;
			}

			CreditCard creditCard = factory.GetCreditCard();
			Console.WriteLine("\nYour card details are below : \n");
			Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
					creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
			Console.ReadKey();
		}
	}
}
