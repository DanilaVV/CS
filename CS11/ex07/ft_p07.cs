using System;

class Program
{
	unsafe static string	ft_show(double nm)
	{
		string	st;
		char	ch;

		st = "";
		for (int i = 0; i < 64; i++)
		{
			st += (nm % 2);
			nm /= 2;
		}
		fixed (char *uk = st)
		{
			for (int i = 0, j = st.Length - 1; i < st.Length / 2; i++, j--)
				{
					ch = uk[i];
					uk[i] = uk[j];
					uk[j] = ch;
				}
		}
		return (st);
	}
	unsafe static void	Main()
	{
		double	nm;
		byte *[]	ms;

		nm = 1;
		Console.WriteLine(nm);
		Console.WriteLine(ft_show(nm));
		ms = new byte*[(sizeof(double) / 2)];
		for (int i = 0, j = 0; i < ms.Length; i++, j += 2)
			ms[i] = ((byte*)&nm) + j;
		for (byte i = 0; i < ms.Length; i++)
			ms[i][0] = (byte)(i + 1);
		Console.WriteLine(nm);
		Console.WriteLine(ft_show(nm));
	}
}
