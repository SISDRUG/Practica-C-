internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        double x = 5;
        x /= 10;
        Console.WriteLine(x);
        double y = x * Math.Pow(Math.E, x*x ) - (Math.Sin(Math.Sqrt(x)) + Math.Pow(Math.Cos(Math.Log10(x)),2))/(Math.Sqrt(Math.Abs(1 - Math.PI * x)));
        Console.WriteLine($"y = {y}");
        Console.Read();
    }
}