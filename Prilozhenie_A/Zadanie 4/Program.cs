internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input R1 OM");
        int R1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input R2 OM");
        int R2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input R3 OM");
        int R3 = Convert.ToInt32(Console.ReadLine());
        if (R1<=R2 & R1<R3)
        {
            Console.WriteLine($"{R1} OM");
        }else if (R2<R1 & R2<= R3)
        {
            Console.WriteLine($"{R2} OM");
        }
        else { Console.WriteLine($"{R3} OM"); }
        Console.ReadLine();
    }
}