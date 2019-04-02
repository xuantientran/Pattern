using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior.Command
{
	public class TestCommand
	{
		public static void Test()
		{
			// Create user and let her compute
			User user = new User();

			// User presses calculator buttons
			user.Compute('+', 100);
			user.Compute('-', 50);
			user.Compute('*', 10);
			user.Compute('/', 2);

			// Undo 4 commands
			user.Undo(4);

			// Redo 3 commands
			user.Redo(3);

			// Wait for user
			Console.ReadKey();
		}

		/// <summary>
		/// In this example Remote act as an invoker as it invokes DVD or VCR related command request passed to it by the client. Objects beginning with DVD and VCR act as receiver objects and they know how to complete the request. Thus, we can say that Remote(Sender) object does not have any knowledge of the operation, it just invokes the implementation through Execute method. However Receivers know very well how to implement the requested operation (Start or Stop). Hence there is decoupling between Sender(Remote) and Receiver(DVD/VCR).
		/// </summary>
		public static void TestMedia()
		{
			//Instantiate the invoker object
			Remote remote = new Remote();
			//Instantiate DVD related commands and pass them to invoker object
			ICommand dvdPlayCommand = new DVDPlayCommand();
			remote.Invoke(dvdPlayCommand);
			ICommand dvdStopCommand = new DVDStopCommand();
			remote.Invoke(dvdStopCommand);
			//Instantiate VCR related commands and pass them to invoker object
			ICommand vcrPlayCommand = new VCRPlayCommand();
			remote.Invoke(vcrPlayCommand);
			ICommand vcrStopCommand = new VCRStopCommand();
			remote.Invoke(vcrStopCommand);
		}
	}
}