using System;

delegate int	delega(char ch, string st);

class Program
{

	static int	ft_met1(char ch, string st)
	{
		int	k;

		k = 0;
		foreach (var c in st)
			if (c == ch)
				k++;
		return (k);
	}

	static int	ft_met2(char ch, string st)
	{
		int	k;

		k = -1;
		for (int i = 0; i < st.Length; i++)
			if (st[i] == ch)
			{
				k = i;
				break ;
			}
		return (k);
	}

	static void	Main()
	{
		delega	del;

		del = ft_met1;
		Console.WriteLine(del('e',"Here is only one"));
		del = ft_met2;
		Console.WriteLine(del('e', "Here is only one"));
	}
}
