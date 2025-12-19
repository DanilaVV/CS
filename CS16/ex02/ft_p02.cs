using System;

class Program
{
	static void	Main()
	{
		int	d;
		int	m;
		int	y;
		DateTime	dt;
		DateTime	Now;

		Now = DateTime.Now;
		Console.Write("Write year of your birth: ");
		y = Int32.Parse(Console.ReadLine());
		Console.Write("Write month of your birth: ");
		m = Int32.Parse(Console.ReadLine());
		Console.Write("Write day of your birth: ");
		d = Int32.Parse(Console.ReadLine());
		dt = new DateTime(y, m, d);
		Console.Clear();
		y = 0;
		while (true)
		{
			if (dt.AddYears(1) < Now)
			{
				y++;
				dt = dt.AddYears(1);
			}
			else
				break ;
		}
		m = 0;
		while (true)
		{
			if (dt.AddMonths(1) < Now)
			{
				m++;
				dt = dt.AddMonths(1);
			}
			else
				break ;
		}
		d = 0;
		while (true)
		{
			if (dt.AddDays(1) < Now)
			{
				d++;
				dt = dt.AddDays(1);
			}
			else
				break ;
		}
		Console.WriteLine("Now your age is: {0} years, {1} months, {2} days", y, m, d);
	}
}
