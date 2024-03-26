internal class Program
{
    
        /// <summary>
        /// Метод f, который возвращает целое число.
        /// </summary>
        /// <param name="x">Входной параметр типа double.</param>
        /// <param name="a">Первый входной параметр типа int.</param>
        /// <param name="b">Второй входной параметр типа int.</param>
        /// <returns>Возвращает результат вычисления в зависимости от условий.</returns>
        public static int f(double x, int a, int b)
     {
        if (Math.Pow(x, 2) - (5 * x) < 0)
        {
            return a + b;
        }
        else if (Math.Pow(x, 2) - (5 * x) < 10)
        {
            return a - b;
        }
        else { return a * b; }
     }

        /// <summary>
        /// Метод f, который возвращает результат через выходной параметр.
        /// </summary>
        /// <param name="x">Входной параметр типа double.</param>
        /// <param name="a">Первый входной параметр типа int.</param>
        /// <param name="b">Второй входной параметр типа int.</param>
        /// <param name="y">Выходной параметр, в который записывается результат.</param>
        public static void f(double x, int a, int b, out double y)
    {
        if (Math.Pow(x, 2) - (5 * x) < 0)
        {
             y = a + b;
        }
        else if (Math.Pow(x, 2) - (5 * x) < 10)
        {
            y = a - b;
        }
        else { y = a * b; }
    }
    private static void Main(string[] args)
    {
        int a = 2;
        int b = 15;
        int h = 1;
        int y1;
        double y = 0;
        for (int x = a; x <= b; x += h)
        {
            Console.WriteLine(x);
            y1 = f(x, a, b);
            Console.WriteLine($"y1 = {y1}");
            f(x, a, b, out y);
            Console.WriteLine($"y = {y}");
        }
    }
}