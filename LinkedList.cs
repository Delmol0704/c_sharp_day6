using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		
		LinkedList<string> vs = new LinkedList<string>();
		vs.AddLast("Delmol");
		vs.AddLast("Denny");
		vs.AddLast("is");
		vs.AddLast("in");
		vs.AddLast("India");
		Console.WriteLine(vs.First.Value);
		Console.WriteLine(vs.Last.Value);
		Console.WriteLine(vs.Contains("India"));
		foreach (var item in vs)
		{
			Console.WriteLine(item);
		}
		Console.ReadLine();				  
	}
}