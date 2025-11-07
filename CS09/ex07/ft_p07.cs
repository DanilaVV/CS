using System;

delegate int	delega(int nm);

class Program
{
	static delega	ft_met(delega del1, delega del2)
	{
		return (nm => del2(del1(nm)));
	}
	static void	Main()
	{
		Console.WriteLine((ft_met(n => n * 2, n => n * 10))(1));
	}
}
