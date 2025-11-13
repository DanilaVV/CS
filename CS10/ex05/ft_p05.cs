using System;

struct MyStruct
{
	int	n1;
	int	n2;

	public MyStruct(int n1, int n2)
	{
		this.n1 = n1;
		this.n2 = n2;
	}

	public override string	ToString()
	{
		return ("Num1: " + n1 + "\tNum2: " + n2);
	}

	public static MyStruct	operator+(MyStruct m1, MyStruct m2)
	{
		return (new MyStruct(m1.n1 + m2.n1, m1.n2 + m2.n2));
	}

	public static MyStruct	operator-(MyStruct m1, MyStruct m2)
	{
		return (new MyStruct(m1.n1 - m2.n1, m1.n2 - m2.n2));
	}

	public static MyStruct	operator*(MyStruct m1, MyStruct m2)
	{
		return (new MyStruct(m1.n1 * m2.n1, m1.n2 * m2.n2));
	}

	public static int	operator~(MyStruct m)
	{
		if (m.n1 < m.n2)
			return (m.n1);
		return (m.n2);
	}

	public static int	operator!(MyStruct m)
	{
		if(m.n1 < m.n2)
			return (m.n2);
		return (m.n2);
	}
}

class Program
{
	static void	Main()
	{
		MyStruct	m1;
		MyStruct	m2;

		m1 = new MyStruct(3, 7);
		m2 = new MyStruct(-4, 8);
		Console.WriteLine(m1);
		Console.WriteLine(m2);
		Console.WriteLine(m1 + m2);
		Console.WriteLine(m1 - m2);
		Console.WriteLine(m1 * m2);
		Console.WriteLine(~m2);
		Console.WriteLine(!m2);
	}
}
