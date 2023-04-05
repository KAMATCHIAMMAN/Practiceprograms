using System.Text;
namespace handBand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine(); ;
            string resultString = "";
            char first = str[0];
            char last = str[(str.Length)-1];
            Console.WriteLine(first);
            Console.WriteLine(last);
            if (first.Equals(last))
            {
                resultString=resultString+str;
                resultString=resultString+str;
                Console.WriteLine(char.ToUpper(resultString[0])+resultString.Substring(1));
            }
            else
            {
                resultString=resultString+str;
                Console.WriteLine("The"+char.ToUpper(resultString[0])+resultString.Substring(1));

            }
        }
    }
}