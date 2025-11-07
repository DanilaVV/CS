using System;

delegate string	delega();

class Program
{
	static int	n = 0;

	static void	Main()
	{
		delega	del;

		del = () => {
			n++;
			switch ((n - 1) % 7)
			{
				case 0: return ("Mon");
				case 1: return ("Tue");
				case 3: return ("Wed");
				case 4: return ("Thu");
				case 5: return ("Fri");
				case 6: return ("Sat");
				default: return ("Sun");
			}
	};
		for (int i = 0; i < 10; i++)
			Console.WriteLine(del());
	}
}
