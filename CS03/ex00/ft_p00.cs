using System;

class MyClass
{
	char	ch;

	public void	ft_set(char c)
	{
		ch = c;
	}

	public int	ft_get()
	{
		return (ch);
	}

	public void	ft_show()
	{
		Console.WriteLine("Char: " + ch + "\nCode: " + ft_get());
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass();
		m.ft_set('D');
		m.ft_show();
	}
}
