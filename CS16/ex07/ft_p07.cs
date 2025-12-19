using System;
using System.Collections;

class Program
{
	static void	Main()
	{
		string	st;
		ArrayList	ls;

		st = Console.ReadLine();
		ls = new ArrayList();
		var ms = st.Split();
		foreach (var n in ms)
			ls.Add(n);
		foreach (var n in ls)
			Console.WriteLine(n);
	}
}
