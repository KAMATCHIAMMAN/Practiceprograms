using System;
using System.Collections;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the string");
        string StringOne = Console.ReadLine();
        Hashtable hashString = new Hashtable();
        for (int item = 0; item<StringOne.Length; item++)
        {
            hashString.Add(item, StringOne[item]);
        }
        char ch = '*';
        int c = 0;
        int i = 1;
        for (int item = 0; item<StringOne.Length; item++)
        {
            if (hashString[item].Equals(ch))
            {
                c=c+1;
                if (hashString.ContainsKey(item-1))
                {
                    hashString.Remove(item);
                    hashString.Remove(item-1);
                }
                else
                {
                    hashString.Remove(item);
                    hashString.Remove(item-c-i);
                    i++;
                }

            }
        }
        string FinalString = "";
        foreach (var key in hashString.Keys)
        {
            FinalString=FinalString+hashString[key].ToString();
        }
        char[] stringArray = FinalString.ToCharArray();
        Array.Reverse(stringArray);
        string ResultString = new string(stringArray);
        if (ResultString.Length!=0)
            Console.WriteLine(ResultString);
        else
            Console.WriteLine("Empty String");
    }
}