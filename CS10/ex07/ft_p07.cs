using System;

struct MyStruct1
{
	char	ch;

	public MyStruct1(char c)
	{
		ch = c;
	}

	public override string	ToString()
	{
		return ("MyStruct1: " + ch);
	}
}

struct MyStruct2
{
	string	st;

	public MyStruct2(string s)
	{
		st = s;
	}

	public MyStruct1 ft_met(int i)
	{
		return (new MyStruct1(st[i % st.Length]));
	}

	public override string	ToString()
	{
		return ("MyStruct2: " + st);
	}
}

class Program
{
	static void	Main()
	{
		MyStruct2	m;

		m = new MyStruct2("It is raining now.");
		Console.WriteLine(m);
		Console.WriteLine(m.ft_met(7));
	}
}
