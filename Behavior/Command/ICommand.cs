using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior.Command
{
	/// <summary>
	/// Command Interface
	/// </summary>
	public interface ICommand
	{
		/// <summary>
		/// Toutes les objets concretes doivent fournir cette methode.
		/// Ce la permet le invoker déclencher cette méthode avec réussite
		/// </summary>
		void Execute();
	}
}
