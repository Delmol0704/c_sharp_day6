Create a list and take input from user .at least 5 values should be there in list
find odd and even from a list


using System;
using System.Collections.Generic;
					
public class Program
{
	
	public static void Main()
	{
		List<int> mylist = new List<int>();
		Console.WriteLine("Enter 5 numbers : ");
		for(int i=0; i<5; i++)
		{
			mylist.Add(Convert.ToInt32(Console.ReadLine()));
		}
		foreach ( var item in mylist)
		{
			if(item % 2 == 0)
				Console.WriteLine(item+" is even");
			else
				Console.WriteLine(item+" is odd");
		}
				
		Console.ReadLine();
	}
}