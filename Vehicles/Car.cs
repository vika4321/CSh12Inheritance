using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicles
{
	class Car: Vehicle
	{
		public void Accelerate()
		{
			Console.WriteLine("Accelerating");
		}

		public void Break()
		{
			Console.WriteLine("Breaking");
		}

		public override void Drive()
		{
			Console.WriteLine("Motoring");
		}
	}
}
