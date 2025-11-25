using System;
using System.Threading;

class Program
{
	static int	ft_fact(int nm)
	{
		if (nm == 1)
			return (nm);
		return (nm * ft_fact(nm - 1));
	}
	static int	ft_dfact(int nm)
	{
		if (nm == 1 || nm == 2)
			return (nm);
		return (nm * ft_dfact(nm - 2));
	}
	static int	ft_fibo(int nm)
	{
		if (nm == 1 || nm ==2)
			return (1);
		return (ft_fibo(nm - 2) + ft_fibo(nm - 1));
	}
	static void	Main()
	{
		int	nm;
		Thread	t1;
		Thread	t2;
		Thread	t3;

		nm = Int32.Parse(Console.ReadLine());
		t1 = new Thread(() => Console.WriteLine(ft_fact(nm)));
		t2 = new Thread(() => Console.WriteLine(ft_dfact(nm)));
		t3 = new Thread(() => Console.WriteLine(ft_fibo(nm)));
		t1.Start();
		Thread.Sleep(10);
		t2.Start();
		Thread.Sleep(10);
		t3.Start();
	}
}
