using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior.Visitor
{
	/// <summary>
	/// la hiérarchie des Visiteurs (contenant les traitements sur les données)
	/// </summary>
	public interface IVisitor
	{
		void Visit(Car car);
		void Visit(Bike bike);
	}
}
