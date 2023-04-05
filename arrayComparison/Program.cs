using System.Text;
namespace arrayComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string string1 = Console.ReadLine();
            string[] strarr = string1.Split(" ");
            int flag = 0;
            for (int i = 0; i<(strarr.Length)-1; i++)
            {
                string string2 = "";
                string string3 = "";
                char last = '\0';
                char first = '\0';
                string2=strarr[i];
                string3=strarr[i+1];
                last=string2[(string2.Length)-1];
                first=string3[0];
                if (last.Equals(first))
                {
                    flag=0;
                }
                else
                {
                    flag=1;
                }
            }
            if (flag==0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}