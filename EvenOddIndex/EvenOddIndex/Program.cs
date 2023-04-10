namespace EvenOddIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String :");
            string str = Console.ReadLine();
            string firstpart = "";
            string secondpart = "";
            for(int i=0;i<str.Length;i++)
            {
                if(i%2==0)
                {
                    firstpart=firstpart+str[i];
                }
                else
                {
                    secondpart=secondpart+str[i];
                }
            }
            Console.WriteLine(firstpart+" "+secondpart);

        }
    }
}