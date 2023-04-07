namespace hierarchial_inheritance
{

    public class Father
    {
        public string FatherName()
        {
            return "Ravi";
        }
    }


    public class ChildFirst : Father
    {
        public string ChildDName()
        {
            return "Rohan";
        }
    }


    public class ChildSecond : Father
    {
        public string ChildDName()
        {
            return "Nikhil";
        }
    }
    public class Program
    {
        public static void Main()
        {
            ChildFirst first = new ChildFirst();

            Console.WriteLine("My name is " + first.ChildDName() +
                              ". My father name is " +
                              first.FatherName() + ".");
            ChildSecond second = new ChildSecond();


            Console.WriteLine("My name is " + second.ChildDName() +
                              ". My father name is " +
                              second.FatherName() + ".");
        }
    }
}