using System;
using System.Collections.Generic;

public class GFG
{

    public static double findSqrt(double x)
    { 
        if (x < 2)
            return x;
        double y = x;
        double z = (y + (x / y)) / 2;
        while (Math.Abs(y - z) >= 0.00001)
        {
            y = z;
            z = (y + (x / y)) / 2;
        }
        return z;
    }

    static public void Main()
    {
        double n = 3;

        double ans = findSqrt(n);
        ans = Math.Round(ans, 5);
        int fa = Convert.ToInt32(ans);
        int a = (fa-1)*(fa-1);
        int b = fa*fa;
        if (fa*fa==n)
        {
            Console.WriteLine("Giver number is a perfect square ");
        }
        else if ((n-a)<(b-n))
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
    }
}
