internal class Program
{
    private static void Main(string[] args)
    {
        int a = -6;
        int b = 4;
        double step = 0.1;

        Parallel.For(Convert.ToInt32(a / step), Convert.ToInt32(b / step), i =>
        {
            double x = i * step;
            double result = 1.0 / Math.Tan(x);

            Console.WriteLine($"x = {x:f2}, ctg(x) = {result:f2}");
        });
    }
}