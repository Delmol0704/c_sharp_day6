using System;
using System.Collections.Generic;
					
public class Program
{
	
	public static void Main()
	{
		//Dictionary<Tkey,TValue>
		/* Dictionary<int, string> dict = new Dictionary<int, string>();
		dict.Add(1,"Delmol");
		dict.Add(2,"Merin");
		dict.Add(3,"Sethu");
		Console.WriteLine(dict[1]);
		foreach (var item in dict)
		{
			Console.WriteLine("key : "+item.Key+"\t value : "+item.Value);
		}
		if(dict.ContainsKey(2))
		{
			Console.WriteLine("key found");
		}
		else
		{
			Console.WriteLine("key not found");
		}
		if(dict.ContainsValue("Delmol"))
		{
			Console.WriteLine("value found");
		}
		else
		{
			Console.WriteLine("value not found");
		}	
		
		*/
		

             // No. of occurence
		Dictionary<char, int> rep = new Dictionary<char, int>();
            Console.Write("Enter a String : ");
            string word = Console.ReadLine();
            for (int i=0;i<word.Length;i++)
            {
                int count = 0;
                foreach (char c in word)
                {
                    if (c == word[i])
                    {
                        count++;
                    }
                }
                if (!rep.ContainsKey(word[i]))
                {
                    rep.Add(word[i], count);
                }
            }
            foreach (var item in rep)
            {
                Console.WriteLine("Key = " + item.Key + "; Value = " + item.Value);
            }

 
	}
}