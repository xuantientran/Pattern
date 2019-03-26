using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.Builder
{
	/// <summary>
	/// Interface des Builders concrets pour s'assurer que tous les builders concrets soient conforme au contrat
	/// </summary>
	interface IPhoneBuilder
	{
		void BuildScreen();
		void BuildBattery();
		void BuildOS();
		void BuildStylus();
		MobilePhone Phone { get; }
	}
}
