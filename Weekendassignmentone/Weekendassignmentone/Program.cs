using System;
public class Program
{
    public void fuel(int time)
    {
        Console.WriteLine("Now we will see the approximate fuel Needs.");
        Console.WriteLine();
        double seconds = time*3600;
        double neededfuel = 0.0003*seconds;
        double max = 60.00f;
        if (neededfuel<max)
        {
            Console.WriteLine("Based on your assumption you will need "+neededfuel.ToString("N2") +" liter fuels to make your journey happy");
            Console.WriteLine("\n");
        }
        else
        {
            int tankfull = Convert.ToInt32(neededfuel/max);
            Console.WriteLine("Based on your assumption you will need"+neededfuel.ToString("N2") +"liter fuels and you need to fill the tank at "+tankfull+"times");
            Console.WriteLine("\n");
        }
    }



    public double speed(int time, double spd)
    {

        Console.WriteLine("Enter you are going in free whelling or not");
        Console.WriteLine("\n");
        string string1 = Console.ReadLine();
        if (string1.Equals("yes"))
        {
            if (spd>250)
            {
                Console.WriteLine("Please enter the valid speed range");
            }
            spd=spd-1;
        }
        Console.WriteLine("Have you done any accelarations :");
        string string2 = Console.ReadLine();
        if (string2.Equals(("yes")))
        {
            Console.WriteLine("Enter number of accelaration you may done during the driving :");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] acc = new int[num];
            double sumacc = 0;
            Console.WriteLine("\n");
            Console.WriteLine("Enter the different accelarations(double):");
            for (int i = 0; i<num; i++)
            {
                acc[i]=Convert.ToInt32(Console.ReadLine());
                if (!(acc[i]>=5 && acc[i]<=20))
                {
                    Console.WriteLine("Enter vaild range");
                    num=num+1;
                }
                sumacc=sumacc+acc[i];
            }
            double avgacc = sumacc/(Convert.ToDouble(num));
            spd=spd+avgacc;
        }
        Console.WriteLine("Have done breaking:");
        string string3 = Console.ReadLine();
        if (string3.Equals("yes"))
        {
            Console.WriteLine("Enter number of breakings you may done during the driving :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int[] brk = new int[num1];
            double sumbrk = 0;
            Console.WriteLine();
            Console.WriteLine("Enter the different breakings(double):");
            for (int i = 0; i<num1; i++)
            {
                brk[i]=Convert.ToInt32(Console.ReadLine());
                if (!(brk[i]>=5 && brk[i]<=20))
                {
                    Console.WriteLine("Enter vaild range");
                    num1=num1+1;
                }
                sumbrk=sumbrk+brk[i];
            }
            double avgbrk = sumbrk/Convert.ToDouble(num1);
            spd=spd-avgbrk;
        }
        return spd;
    }
    public double finalfuellevel(double finalspd, int time, double finalfuel)
    {
        if (finalspd>=1 && finalspd<=60)
        {
            finalfuel =  0.0020*3600*time;
            Console.WriteLine("You have used "+ finalfuel +" liters");
        }
        else if (finalspd>=61 && finalspd<=100)
        {
            finalfuel= 0.0014*3600*time;
            Console.WriteLine("Your have used "+ finalfuel +" liters");
        }
        else if (finalspd>=101 && finalspd<=140)
        {
            finalfuel= 0.0020*3600*time;
            Console.WriteLine("You have used"+ finalfuel +" liters");
        }
        else if (finalspd>=141 && finalspd<=200)
        {
            finalfuel= 0.0025*3600*time;
            Console.WriteLine("You have used "+finalfuel +" liters");
        }
        else if (finalspd>=201 && finalspd<=250)
        {
            finalfuel= 0.0030*3600*time;
            Console.WriteLine("You have used "+finalfuel +" liters");
        }
        return finalfuel;
    }

    public void onboardcompute(double spd, double finalspd, int time, double finalfuellvl)
    {
        Console.WriteLine("1.Trip driving time :"+time);
        Console.WriteLine("2.Total driving time :"+time);
        Console.WriteLine("3.Total driven distance: "+(spd*time));
        Console.WriteLine("4.Actual speed: "+spd);
        Console.WriteLine("5.Total average speed: "+finalspd);
        Console.WriteLine("6.Actual consumption by time :"+(((time*3600*0.0003)*100)/time).ToString("N5"));
        Console.WriteLine("7.actual consumption by distance :"+(((time*3600*0.0003)*100)/(spd*time)).ToString("N1"));
        Console.WriteLine("8.total average consumption by time :"+(finalfuellvl*100)/time);
        Console.WriteLine("9.total average consumption by distance :"+(finalfuellvl*100)/finalspd);

    }





    public static void Main(string[] args)
    {
        Program obj = new Program();
        Console.Write("Enter the car has started are not..If Started Give YES or you can give NO");
        string start = Console.ReadLine();
        if ((start.Equals("YES")) || (start.Equals("yes")))
        {
            Console.WriteLine("Enter the Totel duration in hrs:");
            Console.WriteLine("\n");
            int time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your speed:");
            double spd = Convert.ToDouble(Console.ReadLine());
            obj.fuel(time);
            double finalspd = obj.speed(time, spd);
            double finalfuel = 0;
            double finalfuellvl;
            finalfuellvl=obj.finalfuellevel(finalspd, time, finalfuel);
            obj.onboardcompute(spd, finalspd, time, finalfuellvl);
        }
    }
}

