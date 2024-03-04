internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input x");
        int x = Convert.ToInt32(Console.ReadLine());
        double y;
        if (x > 1)
        {
            y = Math.Log(2 * x)+Math.Sqrt(1+x*x);
        }
        else
        {
            y = 2 * Math.Cos(x) + 3 * x * x;
        }
        Console.WriteLine($"y = {y}");
    }
}