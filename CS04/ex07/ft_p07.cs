using System;

class MyClass
{
	string	st;

	public MyClass(string st)
	{
		this.st = st;
	}

	public void	ft_insert(string s, int i0)
	{
		string	res;
		int	i;

		if (i0 > st.Length)
			return ;
		res = "";
		for (i = 0; i < i0; i++)
			res += st[i];
		foreach (char c in s)
			res += c;
		for (; i < st.Length; i++)
			res += st[i];
		st = res;
	}

	public override string	ToString()
	{
		return (st);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass("Hello!");
		Console.WriteLine(m);
		m.ft_insert(", World", 5);
		Console.WriteLine(m);
		m.ft_insert("!", 100);
		Console.WriteLine(m);
	}
}
