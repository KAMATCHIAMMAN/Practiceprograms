using System.Text;
namespace hidenumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string string1 = Console.ReadLine();
            string string2 = "";
            string string3 = "";
            for (int i = 0; i<((string1.Length)-4); i++)
            {
                string2=string2+"#";
            }
            string3=string1.Substring((string1.Length)-4);
            Console.WriteLine(string2+string3);
        }
    }
}