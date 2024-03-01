internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Vvod dliny");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Vvod visota");
        int h = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"s = {0.5 * a * h}");
        Console.Read();
    }
}