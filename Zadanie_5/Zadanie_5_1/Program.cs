internal class Program
{
    private static void Main(string[] args)
    {
        int[] mass = new int[]{ 2, 5, 3, 1, 4, 3 };
        Console.WriteLine($"Min element = { mass.Min()}");
        Console.WriteLine($"Index of min = {Array.IndexOf(mass,mass.Min())}");
    }
}