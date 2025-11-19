using System;

class Program
{
	unsafe static void	Main()
	{
		int	nm;
		char	**uk;
		char	*u;

		u = (char*)&nm;
		uk = &u;
		(*uk)[0] = 'A';
		(*uk)[1] = 'B';
		Console.WriteLine(nm);
	}
}
