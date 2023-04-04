using System;
public class HelloWorld
{
    static void Main(string[] args)
    {
        string s1 = "kama";
        string s2 = "";
        int i;
        for (i=0; i<s1.Length; i++)
        {
            if (s1[i]!='A' || s1[i]!='E' || s1[i]!='I' || s1[i]!='O' || s1[i]!='U' || s1[i]!='a' || s1[i]!='e' || s1[i]!='i' || s1[i]!='o' || s1[i]!='u' )
        {
                s2=s2+s1[i];
            }
        }
        Console.WriteLine(s2);
    }
}