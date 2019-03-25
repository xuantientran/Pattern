using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior
{
	public class WeightVisitor : IVisitor
	{
		public void Visit(Car car)
		{
			switch (car.CarType)
			{
				case "Mercedes":
					Console.WriteLine("Car {0} weight: {1} KG", car.CarName, 1750);
					break;
				case "Normal":
					Console.WriteLine("Car {0} weight: {1} KG", car.CarName, 750);
					break;
			}
		}

		public void Visit(Bike bike)
		{
			switch (bike.BikeType)
			{
				case "Bullet":
					Console.WriteLine("Bike {0} weight: {1} KG", bike.BikeName, 300);
					break;
				case "Normal":
					Console.WriteLine("Bike {0} weight: {1} KG", bike.BikeName, 100);
					break;
			}
		}
	}
}
