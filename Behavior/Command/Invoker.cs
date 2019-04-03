using System;
using System.Collections.Generic;

namespace Behavior.Command
{
	/// <summary>
	/// la classe 'Invoker' est comme une comptable
	/// Elle connaît : Receiver(la calculatrice pour calculer afin d'écrire sur le dossier), ConcreteCommand (un dossier de comptable) et leurs paramètres
	/// Elle gère la liste de commands (plusieurs dossiers) donc elle rend service au clients comme Compute, Undo, Redo
	/// </summary>
	class Invoker
	{
		// Initializers
		private Calculator _calculator = new Calculator();
		private List<Command> _commands = new List<Command>();
		private int _current = 0;


		public void Compute(char @operator, int operand)
		{
			// Create command operation and execute it
			Command command = new CalculatorCommand(_calculator, @operator, operand);
			command.Execute();

			// Add command to undo list
			_commands.Add(command);
			_current++;
		}

		public void Redo(int levels)
		{
			Console.WriteLine("\n---- Redo {0} levels ", levels);
			// Perform redo operations
			for (int i = 0; i < levels; i++)
			{
				if (_current < _commands.Count - 1)
				{
					Command command = _commands[_current++];
					command.Execute();
				}
			}
		}

		public void Undo(int levels)
		{
			Console.WriteLine("\n---- Undo {0} levels ", levels);
			// Perform undo operations
			for (int i = 0; i < levels; i++)
			{
				if (_current > 0)
				{
					Command command = _commands[--_current] as Command;
					command.UnExecute();
				}
			}
		}
	}
}