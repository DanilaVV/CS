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

	unsafe static void	Main()
	{
		int	n1;
		int	n2;
		int	n3;
		char	*uk;
		Random	r;

		r = new Random();
		n1 = r.Next(100);
		n2 = r.Next(100);
		Console.WriteLine(n1 + "\t" + n2);
		uk = (char*)&n3;
		uk[0] = ((char*)&n1)[0];
		uk[1] = ((char*)&n2)[0];
		Console.WriteLine(n3);
		Console.WriteLine(ft_binary(n1));
		Console.WriteLine(ft_binary(n2));
		Console.WriteLine(ft_binary(n3));
	}
}
