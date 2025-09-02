using System;

interface intf1
{
	int	ft_met(char c);
}

interface intf2
{
	char	ft_met(int n);
}

class MyClass: intf1, intf2
{
	public int	ft_met(char c)
	{
		return ((int)c);
	}

	public char	ft_met(int n)
	{
		return ((char)n);
	}
}

class Program
{
	static void	Main()
	{
		MyClass m = new MyClass();
		intf1 nf1 = m;
		intf2 nf2 = m;
		int nm;
		char c;

		nm = nf1.ft_met('E');
		c = nf2.ft_met(nm);
		Console.WriteLine(c + "\t" + nm);
	}
}
