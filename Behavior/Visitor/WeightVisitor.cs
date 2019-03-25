using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior
{
	public class WeightVisitor : IVisitor
	{
		int carTotalWeight = 0;
		int bikeTotalWeitht = 0;
		public int CarTotalWeight => carTotalWeight;
		public int BikeTotalWeitht => bikeTotalWeitht;
		public void Visit(Car car)
		{
			switch (car.CarType)
			{
				case "Mercedes":
					Console.WriteLine("Car {0} weight: {1} KG", car.CarName, car.Weight);
					break;
				case "Normal":
					Console.WriteLine("Car {0} weight: {1} KG", car.CarName, car.Weight);
					break;
			}
			carTotalWeight += car.Weight;
		}

		public void Visit(Bike bike)
		{
			switch (bike.BikeType)
			{
				case "Bullet":
					Console.WriteLine("Bike {0} weight: {1} KG", bike.BikeName, bike.Weight);
					break;
				case "Normal":
					Console.WriteLine("Bike {0} weight: {1} KG", bike.BikeName, bike.Weight);
					break;
			}
			bikeTotalWeitht += bike.Weight;
		}
	}
}
