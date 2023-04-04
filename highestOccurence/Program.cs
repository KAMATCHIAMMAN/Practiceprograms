namespace highestOccurence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "kamatchi";
            string s2 = s1.ToLower();
            char temp;
            char[] charstr = s2.ToCharArray();
            for(int i=0;i<charstr.Length;i++)
            {
                for (int j=1;j<charstr.Length;j++)
                {
                    if (charstr[i]>charstr[j])
                    {
                        temp=charstr[i];
                        charstr[i]=charstr[j];
                        charstr[j]=temp;
                    }
                }
            }
            string s3 = "";
            for(int i=0;i<charstr.Length-1;i++)
            {
                if (charstr[i]!=charstr[i+1])
                {
                    s3=s3+charstr[i];
                }
            }
            int[] arr = new int[s3.Length];
            for (int i=0;i<s3.Length;i++)
            {
                int c = 0;
                for(int j=0;j<charstr.Length;j++)
                {
                    if (s3[i]==charstr[j])
                    {
                        c=c+1;
                    }
                }
                arr[i]=c;
            }
            int max = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if (max>arr[i])
                {
                    max=arr[i];
                }    
            }
            for(int i=0;i<arr.Length;i++)
            { 
                if (max==arr[i])
                {
                    Console.WriteLine(s3[i]+" "+max);
                    break;
                }
            }
        }
    }
}