using System;

class Program
{
	static bool	ft_comp(string st1, string st2)
	{
		for (int i = 0; i < st1.Length; i++)
			if (!st2.Contains(st1[i]))
				return (false);
		for (int i = 0; i < st2.Length; i++)
			if (!st1.Contains(st2[i]))
				return (false);
		return (true);
	}

	static void	Main()
	{
		Console.WriteLine(ft_comp("242442", "241"));
	}
}
