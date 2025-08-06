using System;

class Program
{
	static string	ft_met(string st, params char[] ms)
	{
		string	res;

		res = st;
		foreach (char c in ms)
			res += c;
		return (res);
	}

	static void	Main()
	{
		Console.WriteLine(ft_met("Table", '1', ' ', '!'));
	}
}
