using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.Builder
{
	public class TestBuilder
	{
		public static void Test()
		{
			//Créer le director
			Director director = new Director();

			//Créer une interface Builder
			IPhoneBuilder phoneBuilder = null;

			//Créer une configuration pour un android
			phoneBuilder = new AndroidPhoneBuilder();

			//Provoquer la fabrication d'un android. Cette fabrication est faite et stockée par le builder.
			director.OrderConstruction(phoneBuilder);

			Console.WriteLine("A new Phone built:\n\n{0}", phoneBuilder.Phone.ToString());

			// Now let us create a Windows Phone
			phoneBuilder = new WindowsPhoneBuilder();
			director.OrderConstruction(phoneBuilder);
			Console.WriteLine("A new Phone built:\n\n{0}", phoneBuilder.Phone.ToString());
		}
	}
}
