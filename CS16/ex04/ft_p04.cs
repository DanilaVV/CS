using System;

class Program
{
	static bool	ft_met(DateTime dt1, DateTime dt2, TimeSpan ts)
	{
		if (dt1 >= dt2 && (dt1 - dt2) <= ts)
			return (true);
		if (dt1 <= dt2 && (dt2 - dt1) <= ts)
			return (true);
		return (false);
	}
	static void	Main()
	{
		DateTime	dt1;
		DateTime	dt2;
		TimeSpan	ts;

		dt1 = new DateTime(2025, 12, 20);
		dt2 = new DateTime(2025, 12, 18);
		ts = new TimeSpan(1, 1, 1, 1);
		Console.WriteLine(ft_met(dt1, dt2, ts));
	}
}
