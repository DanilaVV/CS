using System;
using System.Collections;

class Program
{
	static void	Main()
	{
		SortedList	ms;
		int	size;
		int	n1;
		int	n2;
		int	n3;

		ms = new SortedList();
		size = Int32.Parse(Console.ReadLine());
		if (size < 2)
			size = 2;
		n1 = 1;
		n2 = 2;
		for (int i = 0; i < size; i++)
		{
			if (i == 0 || i == 1)
				ms.Add(i + 1, (char)('A' + (new Random().Next(27))));
			else
			{
				n3 = n1 + n2;
				ms.Add(n3, (char)('A' + (new Random().Next(27))));
				n1 = n2;
				n2 = n3;
			}
		}
		foreach (var n in ms.Keys)
			Console.WriteLine("Key: {0}\tValue: {1}", n, ms[n]);
	}
}
