using System;

delegate int	delega(int nm);

class Program
{

	static void	show(int[] ms)
	{
		foreach (var n in ms)
			Console.Write(n + " ");
		Console.WriteLine();
	}

	static int[]	ft_met(int[] ms, delega del)
	{
		int[]	mms;

		mms = new int[ms.Length];
		for (int i = 0; i < ms.Length; i++)
			mms[i] = del(ms[i]);
		return (mms);
	}
	static void	Main()
	{
		delega	del;
		int[] ms = {1, 2, 3, 4, 5};
		
		del = n => n * n;
		show(ms);
		show(ft_met(ms, del));
	}
}
