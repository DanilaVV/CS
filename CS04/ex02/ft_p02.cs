using System;

class Program
{
	static bool	ft_comp(string st1, string st2)
	{
		int	i;

		i = 0;
		while (i < st1.Length && i < st2.Length)
			if (st1[i] - st2[i] > 1 || st2[i] - st1[i] > 1)
				return (false);
			else
				i++;
		return (true);
	}

	static void	Main()
	{
		Console.WriteLine(ft_comp("231", "24"));
	}
}
