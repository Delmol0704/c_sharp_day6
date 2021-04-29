using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		//LIFO - stack
		Stack<string> vs = new Stack<string>();
		vs.Push("Delmol");
		vs.Push("Denny");
		foreach (var item in vs)
		{
			Console.WriteLine(item);
		}
		Console.ReadLine();				  
	}
}