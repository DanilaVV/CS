using System;

class MyClass
{
	string	st;

	public MyClass(string s)
	{
		st = s;
	}

	public static explicit operator int(MyClass m)
	{
		return (m.st.Length);
	}

	public static explicit operator char(MyClass m)
	{
		return (m.st[0]);
	}

	public static explicit operator MyClass(int n)
	{
		string	res;

		res = "";
		for (int i = 0; i < n; i++)
			res += 'A';
		return (new MyClass(res));
	}

	public override string	ToString()
	{
		return (st + "\t" + (char)this + "\t" + (int)this);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass("One Two Three");
		Console.WriteLine(m);
		m = (MyClass)25;
		Console.WriteLine(m);
	}
}
