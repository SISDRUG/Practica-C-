using System.Xml.Linq;

internal class Program
{
    public static void RectPS(int x1,int x2, int y1, int y2, out int P, out int S)
    {
        if (x1 == x2) { throw new Exception("Rectangle is not exist"); }
        if (y1 == y2) { throw new Exception("Rectangle is not exist"); }
        P = (Math.Abs(x2-x1)+Math.Abs(y1-y2))*2;
        S = Math.Abs(x2 - x1) * Math.Abs(y1 - y2);
    }

    private static void Main(string[] args)
    {
        int x1 = 0,x2 = 0,y1 = 0,y2 = 0 ;
        bool i = false;
        while (i == false)
        {
            try
            {
                Console.WriteLine("Input x1");
                x1 = Convert.ToInt32(Console.ReadLine());
                i = true;
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Invalid Input try again!");
                Console.Beep();
                
            }
        }
        i = false;
        while (i == false)
        {
            try
            {
                Console.WriteLine("Input x2");
                x2 = Convert.ToInt32(Console.ReadLine());
                i = true;
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Input x1");
                Console.WriteLine(x1);
                Console.WriteLine("Invalid Input try again!");
                Console.Beep();

            }
        }
        i = false;
        while (i == false)
        {
            try
            {
                Console.WriteLine("Input y1");
                y1 = Convert.ToInt32(Console.ReadLine());
                i = true;
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Input x1");
                Console.WriteLine(x1);
                Console.WriteLine("Input x2");
                Console.WriteLine(x2);
                Console.WriteLine("Invalid Input try again!");
                Console.Beep();

            }
        }
        i = false;
        while (i == false)
        {
            try
            {
                Console.WriteLine("Input y2");
                y2 = Convert.ToInt32(Console.ReadLine());
                i = true;
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Input x1");
                Console.WriteLine(x1);
                Console.WriteLine("Input x2");
                Console.WriteLine(x2);
                Console.WriteLine("Input y1");
                Console.WriteLine(y1);
                Console.WriteLine("Invalid Input try again!");
                Console.Beep();

            }
        }
        RectPS(x1,x2,y1,y2,out int p, out int s);
        Console.WriteLine($"P = {p}");
        Console.WriteLine($"S = {s}");
    }
}