using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.Builder
{
	/// <summary>
	/// Product: This is the class that will assemble many parts. 
	/// </summary>
	class MobilePhone
	{
		// fields to hold the part type
		string phoneName;
		ScreenType phoneScreen;
		Battery phoneBattery;
		OperatingSystem phoneOS;
		Stylus phoneStylus;

		public MobilePhone(string name) => phoneName = name;

		// Public properties to access phone parts

		public string PhoneName => phoneName;

		public ScreenType PhoneScreen
		{
			get => phoneScreen;
			set => phoneScreen = value;
		}

		public Battery PhoneBattery
		{
			get => phoneBattery;
			set => phoneBattery = value;
		}

		public OperatingSystem PhoneOS
		{
			get => phoneOS;
			set => phoneOS = value;
		}

		public Stylus PhoneStylus
		{
			get => phoneStylus;
			set => phoneStylus = value;
		}

		// Method to display phone details in our own representation
		public override string ToString() =>
			string.Format("Name: {0}\nScreen: {1}\nBattery {2}\nOS: {3}\nStylus: {4}",
					PhoneName, PhoneScreen, PhoneBattery, PhoneOS, PhoneStylus);
	}
}
