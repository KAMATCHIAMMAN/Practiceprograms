using System;
using System.Threading;
namespace ZeroOddEven
{
    public class Threads
    {
        public static void Zero(object zero)
        {
            Console.WriteLine(zero);
        }
        public static void Even(object element)
        {
            Console.WriteLine(element);
        }
        public static void Odd(object element)
        {
            Console.WriteLine(element);
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Thread ThreadA = new Thread(Zero);
            Thread ThreadB = new Thread(Even);
            Thread ThreadC = new Thread(Odd);
            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            int zero = 0;
            for (int element = 1; element<=num; element++)
            {
                Zero(zero);
                if (element%2==0)
                {
                    Even(element);
                }
                else
                {
                    Odd(element);
                }
            }
        }
    }
}


