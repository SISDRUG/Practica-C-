using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Vvod a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Vvod b");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Vvod h");
        int h = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"s = {(a+b)/2 * h}");
        Console.ReadLine();
    }
}