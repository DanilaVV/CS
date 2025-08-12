using System;

class MyClass
{
	string	st;
	char	ch;

	public MyClass(string s, char c)
	{
		st = s;
		ch = c;
	}

	public string[]	ft_sep()
	{
		return (st.Split(ch));
	}

	public override string	ToString()
	{
		string	res;

		res = "";
		res += (st + "\t" + ch + "\n");
		foreach (var n in ft_sep())
			res += (n + "\n");
		return (res);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass("Hello, everyone here!", '1');
		Console.WriteLine(m);
	}
}
