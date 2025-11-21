using System;

class Program
{
	static void	Main()
	{
		int	nm1;
		int	nm2;

label:
		try
		{
			nm1 = Int32.Parse(Console.ReadLine());
			nm2 = Int32.Parse(Console.ReadLine());
			if (nm1 > nm2)
				Console.WriteLine(nm1 % nm2);
			else
				Console.WriteLine(nm2 % nm1);
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
			Console.ReadLine();
			Console.Clear();
			goto label;
		}
	}
}
