using System;

class Program
{

	unsafe static string	ft_binary(int n)
	{
		string	res;
		char	c;

		res = "";
		for (int i = 0; i < 32; i++)
		{
			res += (n % 2 + "");
			n >>= 1;
		}
		fixed (char *uk = res)
		{
			for (int i = 0, j = res.Length - 1; i < res.Length / 2; i++, j--)
			{
				c = uk[i];
				uk[i] = uk[j];
				uk[j] = c;
			}
		}
		return (res);
	}

	unsafe static void	ft_met(int *nn)
	{
		int	nm;
		byte	*uk;
		byte	n;

		nm = *nn;
		uk = (byte*)&nm;
		n = *uk;
		for (int i = 0; i < 3; i++)
		{
			uk[i] = uk[i + 1];
		}
		uk[3] = n;
		*nn = nm;
	}

	unsafe static void	Main()
	{
		int	n;

		n = Int32.Parse(Console.ReadLine());
		Console.WriteLine(n);
		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine(ft_binary(n));
			Console.WriteLine(n);
			ft_met(&n);
		}
	}
}
