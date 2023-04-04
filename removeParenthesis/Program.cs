namespace removeParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Kama(kama)tchi";
            int a = str.IndexOf('(');
            int b = str.IndexOf(')');
            string s2 = "";
            s2=str.Remove(a, Math.Abs((b+1)-a));
            Console.WriteLine(s2);
        }
    }
}