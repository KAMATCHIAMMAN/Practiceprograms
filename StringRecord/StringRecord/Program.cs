using System;
using System.Collections;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("enter the length of the record :");
        int len = Convert.ToInt32(Console.ReadLine());
        string[] record = new string[len];
        int newlen, multiple, added;
        Console.WriteLine("Enter the record elements");
        for (int i = 0; i<len; i++)
        {
            record[i]=Console.ReadLine();
        }
        ArrayList newrecord = new ArrayList();
        foreach (string i in record)
        {
            if (i!="C" && i!="D" && i != "+")
            {
                newrecord.Add(Convert.ToInt32(i));
            }
            if (i.Equals("C"))
            {
                newlen=newrecord.Count;
                newrecord.RemoveAt(newlen-1);
            }
            if (i.Equals("D"))
            {
                newlen=newrecord.Count;
                multiple=Convert.ToInt32(newrecord[newlen-1])*Convert.ToInt32(newrecord[newlen-1]);
                newrecord.RemoveAt(newlen-1);
                newrecord.Add(multiple);
            }
            if (i.Equals("+"))
            {
                newlen=newrecord.Count;
                added=Convert.ToInt32(newrecord[newlen-2])+Convert.ToInt32(newrecord[newlen-1]);
                newrecord.RemoveAt(newlen-1);
                newlen=newrecord.Count;
                newrecord.RemoveAt(newlen-1);
                newrecord.Add(added);
            }
        }
        int sum = 0;
        foreach (int i in newrecord)
        {
            sum=sum+i;
        }
        Console.WriteLine(sum);
    }
}