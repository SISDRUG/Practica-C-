internal class Program
{
    private static void Main(string[] args)
    {
        double a = (Math.PI / 4);
        double b = (Math.PI / 2);
        int m = 15;
        double step = (b - a) / 15;
        double y;

        for (double i = a; i <= b; i+=step)
        {
            y = 1 / Math.Tan(i);
            Console.WriteLine($"F({i}) = {y}");
        }
    }
}