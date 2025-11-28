using System;

class Program
{
	static void	ft_met<X>(X nm)
	{
		if (typeof(X).Name == "Int32")
			Console.WriteLine("This is integer");
		else if (typeof(X).Name == "Char")
			Console.WriteLine("This is character");
		else
			Console.WriteLine("This is not integer and character");
	}
	static void	Main()
	{
		int	n;
		char	c;
		string	s;

		n = 0;
		c = 'E';
		s = "Sunrise";
		ft_met(s);
		ft_met(c);
		ft_met(n);
	}
}
