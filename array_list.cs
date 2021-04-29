using System;
using System.Collections;
					
public class Program
{
	public static void Main()
	{
		ArrayList list = new ArrayList();
		list.Add(1);
		list.Add('A');
		list.Add("Delmol");	
		foreach (var item in list)
		{
			Console.WriteLine(item);
		}
		Console.ReadLine();				  
	}
}