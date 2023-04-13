namespace GenericCastDelegateDemo
{
    public class GenericDelegates
    {
        static void Main(string[] args)
        {
            //delegate double delegateexample(some elements)
            //deligateexample obj =new deligateexample(program.function name)


            Func<int, float, double, double> objone = new Func<int, float, double, double>(circumference);
            double Result = objone.Invoke(2, 3.14f, 10.5876);
            Console.WriteLine("Function generic delegate ");
            Console.WriteLine("circumference of the circule is :"+Result.ToString("N2"));
            Console.WriteLine();

            Action<int, string> objtwo = new Action<int, string>(Printinfo);
            objtwo.Invoke(21, "kamatchi");

            Predicate<string> objthree = new Predicate<string>(CheckLength);
            bool Status = objthree.Invoke("kamatchi");
            Console.WriteLine("Predicate generic delegate ");
            Console.WriteLine(Status);

            Console.ReadKey();
        }

        public static double circumference(int numberone, float numbertwo, double numberthree)
        {
            return numberone*numbertwo*numberthree;
        }

        public static void Printinfo(int numberone, string stringone)
        {
            Console.WriteLine("Action generic delegate");
            Console.WriteLine("Hii I am "+stringone);
            Console.WriteLine("My age is"+numberone);
            Console.WriteLine();
        }

        public static bool CheckLength(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }
    }
}