using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior.Command
{
	/// <summary>
	/// La classe abstracte 'Command'
	/// Pour s'adapter aux plusieurs classe concrète, il ne faut pas spéciser les paramètres dans les deux méthodes en dessous
	/// Les paramètres seront passés par le constructeur.
	/// </summary>
	abstract class Command
	{
		public abstract void Execute();
		public abstract void UnExecute();
	}
}
