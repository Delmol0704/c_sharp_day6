using System;
					
public class Program
{
	public static Tuple<double, double, double, double> Calculator (int a, int b)
	{
		return new Tuple<double, double, double, double>((a+b),(a-b),(a*b),(a/b));
	}
	public static void Main()
	{
		Console.WriteLine("Enter first no : ");
		int x = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter second no : ");
		int y = Convert.ToInt32(Console.ReadLine());
		Tuple<double, double, double, double> output = Program.Calculator(x,y);
		Console.WriteLine("-----------------------");
		Console.WriteLine("\n Sum : "+output.Item1+"\n Difference : "+output.Item2+"\n Product : "+output.Item3+"\n Division : "+output.Item4);
		Console.ReadLine();
	}
}

//nested tuple
//var tuple = Tuple.Create(1, 2, 3, 4, Tuple.Create(5,6), 7, 8);
//Console.WriteLine(tuple.Item1 + tuple.Item2 + tuple.Item3 + tuple.Item4 + tuple.Item5.Item1 + tuple.Item5.Item2 + tuple.Item6 + tuple.Item7);