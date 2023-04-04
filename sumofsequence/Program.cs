using System.Diagnostics;

namespace sumofsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, last, increment;
            Console.WriteLine("Enter start,end,increment");
            start=Convert.ToInt32(Console.ReadLine());
            last=Convert.ToInt32(Console.ReadLine());
            increment=Convert.ToInt32(Console.ReadLine());
            int s = 0;
            if (start>last)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = start; i<=last; i=i+increment)
                {
                    s=s+i;
                    Console.WriteLine(i);
                }
                Console.WriteLine(s);

            }
        }
    }
}