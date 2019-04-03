using System;

namespace Behavior.Command
{
	/// <summary>
	/// La classe concrète de l'interface Command
	/// On garde tous les paramètres y compris la calculatrice
	/// Pour qu'on puisse annuler le calcul
	/// </summary>
	class CalculatorCommand : Command
	{
		private char _operator;
		private int _operand;
		private Calculator _calculator;

		/// <summary>
		/// Tous les paramètres sont mis en place prêts à éxecuter
		/// soit un caclul, un recalcul ou un annulation
		/// </summary>
		/// <param name="calculator"></param>
		/// <param name="operator"></param>
		/// <param name="operand"></param>
		public CalculatorCommand(Calculator calculator,
			char @operator, int operand)
		{
			_calculator = calculator;
			_operator = @operator;
			_operand = operand;
		}

		/// <summary>
		/// Execute new command
		/// </summary>
		public override void Execute() =>
			_calculator.Calculate(_operator, _operand);

		/// <summary>
		/// Unexecute last command
		/// </summary>
		public override void UnExecute() =>
			_calculator.Calculate(ReverseOperator(_operator), _operand);

		/// <summary>
		/// Returns opposite operator for given operator
		/// </summary>
		/// <param name="operator"></param>
		/// <returns></returns>
		private char ReverseOperator(char @operator)
		{
			switch (@operator)
			{
				case '+': return '-';
				case '-': return '+';
				case '*': return '/';
				case '/': return '*';
				default:
					throw new ArgumentException("@operator");
			}
		}
	}
}