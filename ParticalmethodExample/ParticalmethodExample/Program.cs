namespace ParticalmethodExample
{
    partial class Sumofevennumber
    {
        partial void sumeven(int[] integerarray);
    }
    partial class Sumofevennumber
    {
        partial void sumeven(int[] integerarray)
        {
            int sum = 0;
            for (int item = 0; item<integerarray.Length; item++)
            {
                if (integerarray[item]%2==0)
                {
                    sum=sum+integerarray[item];
                }
            }
            Console.WriteLine("Sum of the even numbers are :"+sum);
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the length:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] integerarray = new int[num];
            for (int item = 0; item<num; item++)
            {
                integerarray[item]=Convert.ToInt32(Console.ReadLine());
            }
            new Sumofevennumber().sumeven(integerarray);
        }
    }
}