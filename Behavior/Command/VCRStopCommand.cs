using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior.Command
{
	/// <summary>
	/// These objects would act as Receivers and execute requested functionality through Execute method
	/// </summary>
	public class VCRStopCommand : ICommand
	{
		public VCRStopCommand()
		{
		}
		public void Execute()
		{
			Console.WriteLine("VCR Stopped.");
		}
	}
}
