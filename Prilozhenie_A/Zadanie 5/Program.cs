internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input H");
        int h = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input R");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Square {2 * Math.PI * Math.Pow(r,2) + 2 * Math.PI * r * h }");
        Console.WriteLine($"Obiem {Math.PI * Math.Pow(r,2) * h}");
        Console.ReadLine();
    }
}