using System;
using System.Threading;

class Program
{
	static void	Main()
	{
		int	nm;
		Random	r;
		Thread	t1;
		Thread	t2;

		r = new Random();
		nm = r.Next(100);
		Console.WriteLine(nm);
		t1 = new Thread(() => {
				while (true) {
				if (nm % 2 == 0)
				Console.WriteLine("Devided by 2");
				Thread.Sleep(1000);
				}
				});
		t2 = new Thread(() => {
				while (true) {
				if (nm % 3 == 0)
				Console.WriteLine("Devided by 3");
				Thread.Sleep(1000);
				}
				});
		t1.Start();
		Thread.Sleep(500);
		t2.Start();
		for (int i = 0; i < 10; i++)
		{
			nm = r.Next(100);
			Console.WriteLine(nm);
			Thread.Sleep(1000);
		}
		t1.Abort();
		t2.Abort();
	}
}
