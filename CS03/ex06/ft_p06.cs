using System;

class MyClass
{
	char	ch;
	string	st;

	public void	ft_set(char c)
	{
		ch = c;
	}

	public void	ft_set(string s)
	{
		st = s;
	}

	public void	ft_set(char[] ms)
	{
		if (ms.Length == 1)
			ch = ms[0];
		else
			st = new string(ms);
	}

	public void	ft_show()
	{
		Console.WriteLine("Char: " + ch + "\nString: " + st);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass();
		m.ft_set(new char[]{'E'});
		m.ft_show();
		m.ft_set(new char[]{'1', '9', '7'});
		m.ft_show();
	}
}
