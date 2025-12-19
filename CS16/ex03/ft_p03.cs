using System;

class Program
{
	static void	Main()
	{
		int	ymin;
		int	ymax;
		DateTime	dt;

		Console.Write("Write an early year: ");
		ymin = Int32.Parse(Console.ReadLine());
		Console.Write("Write a late year: ");
		ymax = Int32.Parse(Console.ReadLine());
		Console.WriteLine("The years when January 1st is Monday: ");
		for (int i = ymin; i <= ymax; i++)
		{
			dt = new DateTime(i, 1, 1);
			if (dt.DayOfWeek == DayOfWeek.Monday)
				Console.WriteLine(i);
		}
	}
}
