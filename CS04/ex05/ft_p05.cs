using System;

class Program
{

	static void	ft_show(char[] ms)
	{
		foreach (var n in ms)
			Console.Write(n + " ");
		Console.WriteLine();
	}

	static int	ft_size(char[] ms)
	{
		int	size;
		int	ch;

		if (ms.Length == 0)
			return (0);
		size = 1;
		for (int i = 1; i < ms.Length; i++)
		{
			ch = 0;
			for (int j = 0; j < i; j++)
				if (ms[i] == ms[j])
					ch++;
			if (ch == 0)
				size++;
		}
		return (size);
	}

	static char[]	ft_search(string st)
	{
		int	size;
		char[]	ms;
		char[]	res;

		size = 0;
		foreach (char c in st)
			if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
				size++;
		ms = new char[size];
		for (int i = 0, j = 0; i < st.Length; i++)
			if ((st[i] >= 'A' && st[i] <= 'Z') || (st[i] >= 'a' && st[i] <= 'z'))
				ms[j++] = st[i];
		size = ft_size(ms);
		res = new char[size];
		for (int i = 1, k = 1; i < ms.Length; i++)
		{
			res[0] = ms[0];
			size = 0;
			for (int j = 0; j < i; j++)
				if (ms[i] == ms[j])
					size++;
			if (size == 0)
				res[k++] = ms[i];
                }
		return (res);
	}

	static void	Main()
	{
		string	st;

		st = "35 Hello! ?";
		Console.WriteLine(st);
		ft_show(ft_search(st));
	}
}
