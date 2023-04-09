using System;
using System.Linq;
public class Loop
{
    static void showFirst(int[] newarr)
    {
        Console.WriteLine("The first item of the array is:"+newarr[0]);
    }
    static void popOut(int[] newarr)
    {
        var ele = newarr.Skip(1);
        Console.WriteLine("New Array after removing the first element...");
        foreach (var res in ele)
        {
            Console.WriteLine(res);
        }
    }
    public static void Main()
    {
        Console.WriteLine("Enter the no.of elemeents in the list:");
        int num = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[num];
        for (int i = 0; i<num; i++)
        {
            arr[i]=int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Array before rotation");
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
        int[] newarr = new int[num];
        for (int i = 0; i<num-1; i++)
        {
            newarr[i]=arr[i+1];
        }
        newarr[num-1]=arr[0];
        Console.WriteLine("Array after the rotation");
        foreach (int i in newarr)
        {
            Console.WriteLine(i);
        }
        showFirst(newarr);
        popOut(newarr);
    }
}
