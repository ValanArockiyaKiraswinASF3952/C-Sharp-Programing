using System;
namespace Ex2;
class Program 
{
	static double power = 1, factorial = 1;
	static double TailorSeries(int value1, int value2)
	{
		double reminder;
		if (value2 == 0)
			return 1;
		reminder = TailorSeries(value1, value2 - 1);
		power = power * value1;
		
		factorial = factorial * value2;
		return (reminder + power / factorial);
	}
	public static void Main(string[] args)
	{
		int value1 = 2, value2 = 8;
		Console.WriteLine(Math.Round(TailorSeries(value1, value2), 4));
	}
}