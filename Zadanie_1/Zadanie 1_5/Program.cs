internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input A [-5;5]");
        var b = Convert.ToDouble(Console.ReadLine());
        while (b < -5 || b > 5) {
            Console.WriteLine("input error");
            Console.WriteLine("repeate");
            Console.WriteLine("Input A [-5;5]");
            b = Convert.ToDouble(Console.ReadLine());
        }
        double a = b;

        Console.WriteLine("Input N [1,10]");
        var c = Convert.ToInt32(Console.ReadLine());
        while (c < 1 || b > 10)
        {
            Console.WriteLine("input error");
            Console.WriteLine("repeate");
            Console.WriteLine("Input N [1;10]");
            c = Convert.ToInt32(Console.ReadLine());
        }

        int n = c;
        double summ = 0;
        for (int i = 0; i<= n; i++)
        {
            summ += Math.Pow(a, i);
        }
        Console.WriteLine($"summ of row = {summ:F4}");
    }
}