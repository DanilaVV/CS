using System;

class Program
{

	static void	ft_met(int nm)
	{
		if (nm % 2 == 0)
			throw (new ArithmeticException());
		else
			throw (new OverflowException());
	}

	static void	Main()
	{
		int	nm;

metka:
		try
		{
			nm = Int32.Parse(Console.ReadLine());
			ft_met(nm);
		}
		catch (OverflowException)
		{
			Console.WriteLine("The number is not chetnoe");
			Console.ReadLine();
			Console.Clear();
			goto metka;
		}
		catch (ArithmeticException)
		{
			Console.WriteLine("The number is chetnoe");
			Console.ReadLine();
			Console.Clear();
			goto metka;
		}
		catch (Exception)
		{
			Console.WriteLine("Number is not correct");
		}
	}
}
