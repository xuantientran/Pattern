using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior.Visitor
{
	public class Bike : IStore
	{
		public string BikeName { get; set; }
		public decimal Price { get; set; }
		public string BikeType { get; set; }
		public int Weight { get; set; }
		/// <summary>
		/// étant provoqué par son méthode Accept, l'élément Bike déclenche la méthode Visit du visitor
		/// En accédant l'élément, le visitor peut traiter ses données selon le type de l'élément
		/// </summary>
		/// <param name="visitor"></param>
		public void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
