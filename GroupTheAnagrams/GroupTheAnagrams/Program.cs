using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("enter the length of list :");
        int length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the list of anagrams :");
        string[] stringarray = new string[length];
        for (int item = 0; item<length; item++)
        {
            stringarray[item]=Console.ReadLine();
        }
        string[] sortedList = new string[length];
        for (int item = 0; item<length; item++)
        {
            char[] ch1 = stringarray[item].ToLower().ToCharArray();
            Array.Sort(ch1);
            sortedList[item]=new string(ch1);
        }
        string[] dist = sortedList.Distinct().ToArray();
        int count = 0;
        for (int item = 0; item<dist.Length; item++)
        {
            count=0;
            Console.WriteLine("set"+item);
            for (int itemtwo = 0; itemtwo<stringarray.Length; itemtwo++)
            {
                char[] ch2 = stringarray[itemtwo].ToLower().ToCharArray();
                Array.Sort(ch2);
                string s1 = "";
                s1=new string(ch2);
                if (dist[item].Equals(s1))
                {
                    Console.WriteLine(stringarray[itemtwo]);
                    count++;
                }
            }
            if (count==0)
            {
                Console.WriteLine(dist[item]);
            }
        }
    }
}