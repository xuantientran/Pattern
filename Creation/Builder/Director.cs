using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.Builder
{
	/// <summary>
	/// le Director qui fournit la méthode Construct pour fabriquer un produit dont ses composants ont été déjà définis par le Builder concret IPhoneBuilder
	/// </summary>
	class Director
	{
		/// <summary>
		/// Méthode à fabriquer un produit dont ses composants ont été déjà définis par le Builder concret IPhoneBuilder
		/// </summary>
		/// <param name="phoneBuilder">le Builder concret IPhoneBuilder</param>
		public void OrderConstruction(IPhoneBuilder phoneBuilder)
		{
			phoneBuilder.BuildBattery();
			phoneBuilder.BuildOS();
			phoneBuilder.BuildScreen();
			phoneBuilder.BuildStylus();
		}
	}
}
