using System;

namespace Behavior.Command
{
	/// <summary>
	/// The 'Receiver' class
	/// </summary>
	class Calculator
	{
		//l'état est toujours maintenu par propriété _curr
		private int _curr = 0;
		public void Calculate(char @operator, int operand)
		{
			switch (@operator)
			{
				case '+': _curr += operand; break;
				case '-': _curr -= operand; break;
				case '*': _curr *= operand; break;
				case '/': _curr /= operand; break;
			}
			Console.WriteLine(
				"Current value = {0,3} (following {1} {2})",
				_curr, @operator, operand);
		}
	}
}
