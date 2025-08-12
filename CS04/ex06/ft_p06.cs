using System;

class Program
{

	static string	ft_sub(string st, int n1, int n2)
	{
		string	res;

		res = "";
		if (n1 + n2 > st.Length)
			n2 = st.Length - n1;
		for (int i = n1; i < n1 + n2; i++)
			res += st[i];
		return (res);
	}

	static void	Main()
	{
		string	st;
		
		st = "Hello, World!";
		Console.WriteLine(st);
		Console.WriteLine(ft_sub(st, 3, 60));
	}
}
