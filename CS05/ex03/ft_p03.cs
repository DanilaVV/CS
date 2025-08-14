using System;

class MyClass
{
	int	nm;
	string	st;

	public MyClass(int n, string s)
	{
		nm = n;
		st = s;
	}

	public static bool	operator>(MyClass m1, MyClass m2)
	{
		if (m1.st.Length > m2.st.Length)
			return (true);
		return (false);
	}

	public static bool	operator<(MyClass m1, MyClass m2)
	{
		if (m1.st.Length < m2.st.Length)
		return (true);
		return (false);
	}
	
	public static bool	operator>=(MyClass m1, MyClass m2)
	{
		if (m1.nm >= m2.nm)
			return (true);
		return (false);
	}

	public static bool	operator<=(MyClass m1, MyClass m2)
	{
		if (m1.nm <= m2.nm)
			return (true);
		return (false);
	}

	public static bool	operator==(MyClass m1, MyClass m2)
	{
		if (m1.st == m2.st && m1.nm == m2.nm)
			return (true);
		return (false);
	}

	public static bool	operator!=(MyClass m1, MyClass m2)
	{
		if (m1 == m2)
			return (false);
		return (true);
	}

	public override bool	Equals(object m)
	{
		return (this == (MyClass)m);
	}

	public override int	GetHashCode()
	{
		return (nm + st.Length);
	}

	public override string	ToString()
	{
		return ("MyClass: " + nm + "\t" + st + "\t" + this.GetHashCode());
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m1, m2;

		m1 = new MyClass(1, "One");
		m2 = new MyClass(2, "Two");
		Console.WriteLine(m1);
		Console.WriteLine(m2);
		Console.WriteLine(m1.Equals(m2));
		Console.WriteLine(m1 <= m2);
	}
}
