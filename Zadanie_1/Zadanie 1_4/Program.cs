internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("input price");
        int x = Convert.ToInt32(Console.ReadLine());

        for (int i = 10; i <= 200; i += 10)
        {
            Console.Write($" {i} p.  ");
        }
        Console.WriteLine();
        for (int i = 10; i <= 200; i += 10)
        {
            Console.Write($"{x * i} c.  ");
            
        }
    }
}