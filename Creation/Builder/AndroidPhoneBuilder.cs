using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.Builder
{
	/// <summary>
	/// Un Builder concret qui définit tous les composants variés mais compatibles au produit Phone.
	/// Mais il n'a pas encore créé un produit.
	/// </summary>
	class AndroidPhoneBuilder : IPhoneBuilder
	{

		MobilePhone phone;

		public AndroidPhoneBuilder() => phone = new MobilePhone("Android Phone");

		public void BuildScreen() => phone.PhoneScreen = ScreenType.ScreenType_TOUCH_RESISTIVE;

		public void BuildBattery() => phone.PhoneBattery = Battery.MAH_1500;

		public void BuildOS() => phone.PhoneOS = OperatingSystem.ANDROID;

		public void BuildStylus() => phone.PhoneStylus = Stylus.YES;

		// GetResult Method which will return the actual phone
		public MobilePhone Phone => phone;
	}
}
