using System;

delegate int	delega();

class Program
{
	static int	n1 = 0;
	static int	n2 = 1;
	static int	n;

	static void	Main()
	{
		delega	del;

		del = () => {
		n = n2;
		n2 = n1 + n2;
		n1 = n;
		return (n1);
		};
		for (int i = 0; i < 10; i++)
			Console.WriteLine(del());
	}
}
