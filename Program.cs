using System;

namespace EstimatePi
{
    class Program
    {
        static void Main(string[] args)
        {
			var montecarlo = new MonteCarlo();

			do
			{
				double estimatedPi = montecarlo.Estimate(AskForAmount());
				DisplayAnswer(estimatedPi);

			} while (UseAgain());

			Environment.Exit(0);
        }

		static int AskForAmount()
		{
			int inputAmount = 0;
			bool hasAnswered = true;
			string message;

			do
			{
				Console.Clear();

				message = hasAnswered ? "Please input the number of tests: "
									  : "Invalid. Please enter a number: ";

				Console.Write(message);
				hasAnswered = (int.TryParse(Console.ReadLine(), out inputAmount));

			} while (!hasAnswered);

			if (inputAmount < 1)
			{
				Console.WriteLine("Please input a number greater than zero.  Press ENTER to continue.");
				Console.ReadKey();
				return AskForAmount();
			}

			return inputAmount;
		}

		static void DisplayAnswer(double estimatedPi)
		{
            var difference = Math.Abs(Math.PI - estimatedPi);

			Console.Clear();
			Console.WriteLine($"The Monte Carlo Method has estimated Pi as being {estimatedPi}");
			Console.WriteLine($"The actual calculation of Pi is {Math.PI}");
			Console.WriteLine($"The difference between the estimated value and actual value is {difference}.");
			Console.ReadKey();
		}

		static bool UseAgain()
		{
			Console.Clear();
			Console.WriteLine("Would you like to try again? Y/N");
			var input = Console.ReadKey(true);
			switch (input.Key)
			{
				case ConsoleKey.Y:
					return true;
				case ConsoleKey.N:
					return false;
				default:
					return UseAgain();
			}
		}
    }
}
