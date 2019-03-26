using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.Factory
{
	class MoneyBackFactory : CardFactory
	{
		private int _creditLimit;
		private int _annualCharge;

		public MoneyBackFactory(int creditLimit, int annualCharge)
		{
			_creditLimit = creditLimit;
			_annualCharge = annualCharge;
		}

		public override CreditCard GetCreditCard() =>
			new MoneyBackCreditCard(_creditLimit, _annualCharge);

	}
}
