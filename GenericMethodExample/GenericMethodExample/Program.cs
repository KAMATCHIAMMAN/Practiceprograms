namespace GenericMethodExample
{
    using System;
    class Add<T1, T2>
    {
        public void added(T1 dataone, T2 datatwo)
        {
            Console.WriteLine("Addedd value is: "+dataone+datatwo);
        }
    }
    class Program
    {
        static void Main()
        {
            Add<string, string> obj = new Add<string, string>();
            obj.added("kama", "sri");
            Add<int, int> objone = new Add<int, int>();
            objone.added(200, 100);
        }
    }
}