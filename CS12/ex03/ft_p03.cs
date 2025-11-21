using System;

class Program
{
	static void	Main()
	{
		int	A;
		int	B;
		int	C;

		Console.WriteLine("A*x^2 + B*X + C = 0");
		try
		{
			Console.Write("A = ");
			A = Int32.Parse(Console.ReadLine());
			Console.Write("B = ");
			B = Int32.Parse(Console.ReadLine());
			Console.Write("C = ");
			C = Int32.Parse(Console.ReadLine());
			if (A == 0)
				if (B == 0 && C == 0)
					Console.WriteLine("x = any");
				else if (B == 0)
					Console.WriteLine("No solution");
				else
					Console.WriteLine("x = " + (-C) / B);
			else if (B * B - 4 * A * C < 0)
				Console.WriteLine("No solution");
			else if (B * B - 4 * A *C == 0)
				Console.WriteLine("x = " + (-B) / (2 * A));
			else
			{
				Console.WriteLine("x1 = " + ((-B) - Math.Sqrt(B * B - 4 * A * C) / (2 * A)));
				Console.WriteLine("x2 = " + ((-B) + Math.Sqrt(B * B - 4 * A * C) / (2 * A)));
			}
		}
		catch
		{
			Console.WriteLine("No solution");
		}
	}
}
