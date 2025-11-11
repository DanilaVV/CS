using System;

enum DaysOfWeek{Mon, Tue, Wed, Thu, Fri, Sat, Sun};

class Program
{

	static void	ft_day(int day)
	{
		Console.WriteLine((DaysOfWeek)((day - 1) % 7));
	}

	static int	ft_delta(DaysOfWeek d1, DaysOfWeek d2)
	{
		if (d1 == d2)
			return (0);
		if (d1 < d2)
			if (d2 - d1 < 7 + d1 - d2)
				return (d2 - d1 - 1);
			else
				return (7 + d1 - d2 - 1);
		if (d1 - d2 < 7 + d2 - d1)
			return (d1 - d2 - 1);
		else
			return (7 + d2 - d1 - 1);
	}

	static void	Main()
	{
		ft_day(8);
		Console.WriteLine(ft_delta(DaysOfWeek.Tue, DaysOfWeek.Fri));
	}
}
