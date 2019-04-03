using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior.CommandSimple
{
	/// <summary>
	/// Remote object which would act as an invoker and would invoke operation requested by Client. This object has a method called Invoke which takes an ICommand object as parameter and invokes its Execute method.
	/// </summary>
	public class Remote
	{
		public void Invoke(ICommand cmd)
		{
			Console.WriteLine("Invoking.......");
			cmd.Execute();
		}
	}
}
