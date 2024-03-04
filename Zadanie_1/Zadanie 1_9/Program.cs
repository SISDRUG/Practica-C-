internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("input price [1;100] ");
        double x = Convert.ToInt32(Console.ReadLine());

        for (double i = 0.1; i <= 1; i += 0.1)
        {
            Console.Write($" {i:f1} kg.  ");
        }
        Console.WriteLine();
        for (double i = 0.1; i <= 1; i += 0.1)
        {
            Console.Write($" {x * i:F2} c.  ");

        }
    }
}