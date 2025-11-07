using System;

delegate double	delega(double x);

class Program
{

	static delega	ft_met(double n1, double n2, double n3)
	{
		return (x => n1 * x * x + n2 * x + n3);
	}

	static void	Main()
	{
		Console.WriteLine(ft_met(-2, 3, 7)(0.33));
	}
}
