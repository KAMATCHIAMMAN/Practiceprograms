using System;
using System.Threading;
namespace FirstSecondThirdThread
{
    public class Threads
    {
        public static void first()
        {
            Console.WriteLine("First");
        }
        public static void second()
        {
            Console.WriteLine("Second");
        }
        public static void third()
        {
            Console.WriteLine("Third");
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the three elements:");
            int[] array = new int[3];
            for (int item = 0; item<3; item++)
            {
                array[item]=Convert.ToInt32(Console.ReadLine());
            }
            Thread ThreadA = new Thread(first);
            Thread ThreadB = new Thread(second);
            Thread ThreadC = new Thread(third);
            for (int element = 0; element<3; element++)
            {
                if (array[element]==1)
                {
                    ThreadA.Start();
                }
                else if (array[element]==2)
                {
                    ThreadB.Start();
                }
                else
                {
                    ThreadC.Start();
                }
            }
        }
    }
}