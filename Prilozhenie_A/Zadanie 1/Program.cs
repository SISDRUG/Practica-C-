internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        

        if (b != 0)
        {
            double result = a / b;
            Console.WriteLine($"{a:F3} / {b:f3} = {result :f3}");
        }
        else
        {
            Console.WriteLine("Деление на ноль невозможно.");
        }

        Console.ReadLine();
    }
}