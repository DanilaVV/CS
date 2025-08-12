using System;

class Program
{

	static void	ft_show(int[] ms)
	{
		foreach (int n in ms)
			Console.Write(n + " ");
		Console.WriteLine();
	}

	static int[]	ft_search(string st, char ch)
	{
		int	size;
		int[]	ms;

		size = 0;
		foreach (char c in st)
			if (c == ch)
				size++;
		if (size == 0)
			ms = new int[]{-1};
		else
		{
			ms = new int[size];
			for (int i = 0, j = 0; i < st.Length; i++)
				if (st[i] == ch)
					ms[j++] = i;
		}
		return (ms);
	}

	static void	Main()
	{
		string	st;

		st = "There is many apples";
		Console.WriteLine(st);
		ft_show(ft_search(st, '4'));
	}
}
