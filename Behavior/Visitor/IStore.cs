using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior
{
	/// <summary>
	/// la hiérarchie des objets support de données
	/// </summary>
	public interface IStore
	{
		/// <summary>
		/// étant provoqué par son méthode Accept, l'élément Bike déclenche la méthode Visit du visitor
		/// En accédant l'élément, le visitor peut traiter ses données selon le type de l'élément
		/// </summary>
		/// <param name="visitor"></param>
		void Accept(IVisitor visitor);
	}
}
