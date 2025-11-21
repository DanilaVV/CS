using System;

class Prgram
{
	static int	ft_met(int[] ms, int nm)
	{
		try
		{
			for (int i = 0; i < ms.Length; i++)
				if (ms[i] == nm)
					return (i);
			throw (new Exception());
		}
		catch
		{
			return (-1);
		}
	}

	static void	Main()
	{
		int[]	ms;
		int	nm;

		nm = 2;
		ms = new int[]{1, 2, 3, 4, 1, 5, 2};
		if (ft_met(ms, nm) < 0)
			Console.WriteLine("The array doesn't contain a such number");
		else
			Console.WriteLine(ft_met(ms, nm));
	}
}
