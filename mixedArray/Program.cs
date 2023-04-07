using System.Collections;
using System;
namespace mixedArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrlist = new ArrayList() { 1, "2", 3, '4' };
            int sum = 0;
            int sum2 = 0;
            int num;
            foreach (var value in arrlist)
            {

                Type tp = value.GetType();
                if (tp.Equals(typeof(int)))
                {
                    int num1 = Convert.ToInt32(value);
                    sum=sum+num1;
                }
                else
                {
                    string string2 = "";
                    string2=value.ToString();
                    num=Int16.Parse(string2);
                    sum2=sum2+num;
                }
            }
            Console.WriteLine("Integer element total is {0} and String element total is {1} Then difference is {2}", sum, sum2, Math.Abs(sum-sum2));
        }
    }
}