namespace Blockprogram
{
    public class Anyblock
    {
        int[] measure = new int[3];
        public Anyblock(int[] measure)
        {
            this.measure = measure;
        }
        public int get_width()
        {
            return measure[0];
        }
        public int get_length()
        {
            return measure[1];
        }
        public int get_height()
        {
            return measure[2];
        }
        public int get_volume()
        {
            return (measure[0]* measure[1]*measure[2]);
        }
        public int get_surfacearea()
        {
            return ((2* measure[0]* measure[1])+(2 * measure[1] * measure[2]) +(2 * measure[2] * measure[0]));

        }
    }

    public static void Main(string[] args)
    {
        int[] b1 = { 2, 4, 6 };
        Anyblock block = new Anyblock(b1);
        Console.WriteLine("Width:"+block.get_width());
        Console.WriteLine("Length:" + block.get_length());
        Console.WriteLine("Height:" + block.get_height());
        Console.WriteLine("Volume:" + block.get_volume());
        Console.WriteLine("Surface Area:" + block.get_surfacearea());

    }
}