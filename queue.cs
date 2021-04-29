using System;
using System.Collections;
					
public class Program
{
	
	public static void Main()
	{
		Queue myqueue = new Queue();
		myqueue.Enqueue("C#");
		myqueue.Enqueue("PHP");
		myqueue.Enqueue("JAVA");
		myqueue.Enqueue("C");
		Console.WriteLine(myqueue.Count);
		Console.WriteLine(myqueue.Peek());
		foreach ( var item in myqueue.ToArray())
		{
				Console.WriteLine(item);
		}
				
		Console.ReadLine();
	}
}