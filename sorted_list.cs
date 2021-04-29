using System;
using System.Collections;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		//system.collection
		//sorted dictionary
		SortedList list = new SortedList();
		list.Add(2,"dog");
		list.Add(1,"cat");
		//sorted already
		foreach(DictionaryEntry item in list)
		{
			Console.WriteLine("Key : "+item.Key+"\t Value : "+ item.Value);
		}
		
		
		//system.collection.generic
		//unsorted data
		SortedList<int, string> list1 = new SortedList<int, string>();
		list1.Add(3, "NASA");
		list1.Add(1, "ISRO");
		list1.Add(2, "CNSA");
		foreach(var item in list1)
		{
			Console.WriteLine("Key : "+item.Key+"\t Value : "+ item.Value);
		}
		Console.ReadLine();
	}
}