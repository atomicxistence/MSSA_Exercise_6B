using System;

namespace EstimatePi
{
	struct Coord
	{

		public double X { get; private set; }
		public double Y { get; private set; }

		public Coord(double x, double y)
		{
			X = x;
			Y = y;
		}

		public Coord(Random randomNumberGenerator)
		{
			X = randomNumberGenerator.NextDouble();
			Y = randomNumberGenerator.NextDouble();
		}
	}
}