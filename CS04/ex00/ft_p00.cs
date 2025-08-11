using System;

class Program
{
	static string	ft_space(string st)
	{
		string	res;
		int	i;

		res = "";
		for (i = 0; i < st.Length - 1; i++)
			res += (st[i] + " ");
		res += st[i];
		return (res);
	}

	static void	Main()
	{
		string	s;

		s = "Danila";
		Console.WriteLine(s + "\n" + ft_space(s));
	}
}
