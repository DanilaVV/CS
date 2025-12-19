using System;
using One;
using Two;
using Three;

namespace One
{
	class Base
	{
		protected string	ft_met1()
		{
			return ("Class Base from namespace One\n");
		}
	}
}

namespace Two
{
	interface inf
	{
		string	ft_met2();
	}
}

namespace Three
{
	class MyClass: Base, inf
	{
		public string ft_met2()
		{
			return ("Interface inf from namespace Two\n");
		}
		public override string	ToString()
		{
			return (ft_met1() + ft_met2() + "MyClass from namespace Three");
		}
	}
}

class Program
{
	static void	Main()
	{
		Console.WriteLine(new MyClass());
	}
}
