using System;

class Program
{
	static string	ft_rev(string st)
	{
		string[]	ms;
		string	res;
		int	i;

		res = "";
		ms = st.Split();
		for (i = 0; i < ms.Length - 1; i++)
			res += (ms[ms.Length - 1 - i] + " ");
		res += ms[0];
		return (res);
	}

	static void	Main()
	{
		string	s;

		s = "It is a very hot day";
		Console.WriteLine(s + "\n" + ft_rev(s));
	}
}
