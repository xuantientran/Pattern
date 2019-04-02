using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior.ChainResponsibility
{
	/// <summary>
	/// The 'Handler' abstract class
	/// </summary>
	public abstract class Approver
	{
		protected Approver _successor;
		public void SetSuccessor(Approver successor)
		{
			_successor = successor;
		}
		public abstract void ProcessRequest(Purchase purchase);
	}
}
