using System;

struct MyStruct1
{
	int	n;

	public MyStruct1(int n)
	{
		this.n = n;
	}

	public override string	ToString()
	{
		return ("MyStruct1: " + n);
	}

	public static MyStruct2	operator+(MyStruct1 m1, MyStruct1 m2)
	{
		return (new MyStruct2(m1.n, m2.n));
	}
}

struct MyStruct2
{
	int	n1;
	int	n2;

	public	MyStruct2(int n1, int n2)
	{
		this.n1 = n1;
		this.n2 = n2;
	}

	public override string	ToString()
	{
		return ("MyStruct2: " + n1 + "\t" + n2);
	}

	public static MyStruct1[] operator~(MyStruct2 m)
	{
		return (new MyStruct1[]{new MyStruct1(m.n1), new MyStruct1(m.n2)});
	}
}

class Program
{
	static void	Main()
	{
		MyStruct2	m;

		m = new MyStruct2(13, 8);
		var ms = ~m;
		Console.WriteLine(ms[0]);
		Console.WriteLine(ms[1]);
		Console.WriteLine(ms[0] + ms[1]);
	}
}
