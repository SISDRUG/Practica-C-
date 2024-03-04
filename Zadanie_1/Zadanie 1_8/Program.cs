internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Данное целое число является нечетным трехзначным числом");
        Console.Write("Проверить :");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{x < 1000 & x % 2 !=0 & x > 100} ");
    }
}