using System;

class MyClass
{
	static int	nm = 0;

	public static void	ft_show()
	{
		Console.WriteLine(nm++);
	}
}

class Program
{
	static void	Main()
	{
		for (int i = 0; i < 10; i++)
			MyClass.ft_show();
	}
}
