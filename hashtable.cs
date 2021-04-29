using System;
using System.Collections;
					
public class Program
{
	public static void Main()
	{
		Hashtable list = new Hashtable();
		list.Add(1,"welcome");
		list.Add(2,"to");
		list.Add(3,"C#");
		list.Add(4,"class");
		
		ICollection key = list.Keys;
		foreach (var item in key)
		{
			Console.WriteLine(item+" - "+list[item]);
		}
		Console.ReadLine();				  
	}
}