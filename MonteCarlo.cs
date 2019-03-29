using System;

namespace EstimatePi
{
	class MonteCarlo
	{
		public double Estimate(int iterations)
		{
			Coord[] coords = PoplulateTestCollection(iterations);
			int overlapTotal = OverlapCircle(coords);

			return EstimatedPi(overlapTotal, coords.Length);
		}

		private Coord[] PoplulateTestCollection(int size)
		{
			var coords = new Coord[size];
			var rng = new Random();

			for (int i = 0; i < size; i++)
			{
				coords[i] = new Coord(rng.NextDouble(), rng.NextDouble());
			}

			return coords;
		}

		private int OverlapCircle(Coord[] coords)
		{
			int overlapTotal = 0;

			foreach (var coord in coords)
			{
				if (GetHypotenuse(coord) <= 1)
				{
					overlapTotal += 1;
				}
			}

			return overlapTotal;
		}

		private double GetHypotenuse(Coord coord)
		{
			return Math.Sqrt(Math.Pow(coord.X, 2) + Math.Pow(coord.Y, 2));
		}

		private double EstimatedPi(double overlapCircleAmount, double totalAmount)
		{
			return overlapCircleAmount / totalAmount * 4.0;
		}
	}
}