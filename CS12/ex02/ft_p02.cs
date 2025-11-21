using System;

class Program
{
	static void	Main()
	{
		int	A;
		int	B;

		Console.WriteLine("A*x = B");
		try
		{
			Console.Write("A = ");
			A = Int32.Parse(Console.ReadLine());
			Console.Write("B = ");
			B = Int32.Parse(Console.ReadLine());
			if (A == 0 && B == 0)
				Console.WriteLine("x is any");
			else if (B % A != 0)
				Console.WriteLine("There is not any solution");
			else
				Console.WriteLine("x = " + B / A);
		}
		catch
		{
			Console.WriteLine("There is not any solution");
		}
	}
}
