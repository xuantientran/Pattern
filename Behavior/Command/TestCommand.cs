using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior.Command
{
	//Le client ne connaît que le invoker et son service
	public class TestCommand
	{
		public static void Test()
		{
			// Create invoker and let him compute
			Invoker invoker = new Invoker();

			// User presses calculator buttons
			invoker.Compute('+', 100);
			invoker.Compute('-', 50);
			invoker.Compute('*', 10);
			invoker.Compute('/', 2);

			// Undo 4 commands
			invoker.Undo(4);

			// Redo 3 commands
			invoker.Redo(3);

			// Wait for user
			Console.ReadKey();
		}
	}
}