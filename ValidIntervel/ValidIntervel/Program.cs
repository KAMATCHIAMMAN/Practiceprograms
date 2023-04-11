namespace ValidIntervel
{
    using System;
    using System.Collections;
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the intervels:");
            int intervel = Convert.ToInt32(Console.ReadLine());
            int[][] intervelarr = new int[intervel][];
            for (int i = 0; i<intervel; i++)
            {
                intervelarr[i] = new int[2];
            }
            for (int i = 0; i<intervel; i++)
            {
                Console.WriteLine("Enter two people name");
                for (int j = 0; j<intervelarr[i].Length; j++)
                {
                    intervelarr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            ArrayList arrlst = new ArrayList();
            for (int i = 0; i<intervel-1; i++)
            {
                if ((intervelarr[i][1]>intervelarr[i+1][0]) || (intervelarr[i][1]==intervelarr[i+1][0]))
                {
                    arrlst.Add(intervelarr[i][0]);
                    arrlst.Add(intervelarr[i+1][1]);
                }
                else if (intervelarr[0][1]<intervelarr[1][0])
                {
                    arrlst.Add(intervelarr[0][0]);
                    arrlst.Add(intervelarr[0][1]);
                }
                else
                {
                    arrlst.Add(intervelarr[i+1][0]);
                    arrlst.Add(intervelarr[i+1][1]);
                }
            }
            IntervelOfArrays obj = new IntervelOfArrays();
            try
            {
                obj.showIntervel(arrlst);
            }
            catch (IntervelIsZeroException e)
            {
                Console.WriteLine("IntervelIsZeroExceptionn: {0}", e.Message);
            }
        }
    }

    public class IntervelIsZeroException : Exception
    {
        public IntervelIsZeroException(string message) : base(message) { }
    }
    public class IntervelOfArrays
    {

        public void showIntervel(ArrayList arrlst)
        {
            if (arrlst.Count == 0)
            {
                throw (new IntervelIsZeroException("Zero Intervel is found"));
            }
            else
            {
                int len = (arrlst.Count)/2;
                Console.WriteLine(len);
                int[][] newarr = new int[len][];
                for (int i = 0; i<len; i++)
                {
                    newarr[i] = new int[2];
                }
                int k = 0;
                for (int i = 0; i<len; i++)
                {
                    for (int j = 0; j<2; j++)
                    {
                        newarr[i][j]=(int)arrlst[k];
                        k++;
                    }
                }
                Console.WriteLine("Final Intervels are :");
                for (int i = 0; i<len; i++)
                {
                    for (int j = 0; j<2; j++)
                    {
                        Console.WriteLine(newarr[i][j]);
                    }
                }
            }

        }
    }


}