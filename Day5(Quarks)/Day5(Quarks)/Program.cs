using System;

public class Program
{
    public void interact(string[] quark1, string[] quark2)
    {
        string temp;
        temp=quark1[0];
        quark1[0]=quark2[0];
        quark2[0]=temp;
        Console.WriteLine("QUARK1 :");
        foreach (string i in quark1)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("QUARK2");
        foreach (string i in quark2)
        {
            Console.WriteLine(i);
        }
    }
    public static void Main()
    {
        Console.WriteLine("Enter the first quark olor and flavour");
        string[] quark1 = new string[2];
        string[] quark2 = new string[2];
        for (int i = 0; i<2; i++)
        {
            quark1[i]=Console.ReadLine();
        }
        Console.WriteLine("Enter the second quark olor and flavour");
        for (int i = 0; i<2; i++)
        {
            quark2[i]=Console.ReadLine();
        }
        string[] strarr = { "up", "down", "strange", "charm", "top", "bottom" };
        if ((quark1[0].Equals("red") || quark1[0].Equals("green") || quark1[0].Equals("blue")) && (quark2[0].Equals("red") || quark2[0].Equals("green") || quark2[0].Equals("blue")))
        {
            if ((quark1[1].Equals("up") || quark1[1].Equals("down") || quark1[1].Equals("strange") || quark1[1].Equals("top") || quark1[1].Equals("bottom")) &&
               (quark2[1].Equals("up") || quark2[1].Equals("down") || quark2[1].Equals("strange") || quark2[1].Equals("top") || quark1[1].Equals("bottom")))
            {
                Program obj = new Program();
                string string1 = quark1[0];
                string string2 = quark2[0];
                obj.interact(quark1, quark2);
            }
        }
    }
}