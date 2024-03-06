internal class Program
{

    public static int f(double x, int a, int b)
    {
        if (Math.Pow(x, 2) - (5 * x) < 0)
        {
            return a + b;
        }
        else if (Math.Pow(x, 2) - (5 * x) < 10)
        {
            return a - b;
        }
        else { return a * b; }

    }

    public static void f(double x, int a, int b, out double y)
    {
        if (Math.Pow(x, 2) - (5 * x) < 0)
        {
             y = a + b;
        }
        else if (Math.Pow(x, 2) - (5 * x) < 10)
        {
            y = a - b;
        }
        else { y = a * b; }
    }
    private static void Main(string[] args)
    {
        int a = 2;
        int b = 15;
        int h = 1;
        int y1;
        double y = 0;
        for (int x = a; x <= b; x += h)
        {
            Console.WriteLine(x);
            y1 = f(x, a, b);
            Console.WriteLine($"y1 = {y1}");
            f(x, a, b, out y);
            Console.WriteLine($"y = {y}");
        }
    }
}