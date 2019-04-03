using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior.CommandSimple
{
	/// <summary>
	/// These objects would act as Receivers and execute requested functionality through Execute method
	/// </summary>
	public class DVDPlayCommand : ICommand
	{
		public void Execute()
		{
			Console.WriteLine("DVD Started.");
		}
	}
}
