namespace GenericClassExample
{
    using System;
    public class Hotel<T1, T2>
    {
        private T1 food;
        private T2 amount;
        public Hotel(T1 food, T2 amount)
        {
            this.food=food;
            this.amount=amount;
        }
        public void Menu()
        {
            Console.WriteLine("Type of the food is "+this.food);
            Console.WriteLine("Amount of the food is "+this.amount);
        }
    }

    class Program
    {
        static void Main()
        {
            Hotel<string, int> foodvarity = new Hotel<string, int>("Dosa", 60);
            foodvarity.Menu();
        }
    }
}