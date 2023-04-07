namespace Demo
{
    class Son : Father
    {
        public void DisplayTwo()
        {
            Console.WriteLine("My name is kamatchi ");
        }
        static void Main(string[] args)
        {
            Son s = new Son();
            s.Display();
            s.DisplayOne();
            s.DisplayTwo();
            Console.Read();
        }
    }
    class Grandfather
    {
        public void Display()
        {
            Console.WriteLine("I am black color");
        }
    }
    class Father : Grandfather
    {
        public void DisplayOne()
        {
            Console.WriteLine("My height is 156");
        }
    }
}