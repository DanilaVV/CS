using System;

class MyClass
{
	char	ch1;
	char	ch2;

	public void	ft_set(char c1, char c2)
	{
		ch1 = c1;
		ch2 = c2;
	}
	
	public void	ft_show()
	{
		if (ch1 < ch2)
			for (char c = ch1; c <= ch2; c++)
		Console.Write(c + " ");
		else
			for (char c = ch2; c <= ch1; c++)
				Console.Write(c + " ");
		Console.WriteLine();
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass();
		m.ft_set('a', 'D');
		m.ft_show();
	}
}
