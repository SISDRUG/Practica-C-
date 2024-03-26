internal class Program
{
    /// <summary>
    /// Calculates the value of the function f(x) based on the given conditions.
    /// </summary>
    /// <param name="x">The input value.</param>
    /// <param name="a">Parameter 'a'.</param>
    /// <param name="b">Parameter 'b'.</param>
    /// <returns>The value of the function based on the specified conditions.</returns>
    public static int f(int x, int a, int b)
    {
        if (Math.Pow(x, 2) - (5 * x) < 0)
        {
            return a + b;
        }
        else if (Math.Pow(x, 2) - (5 * x) < 10)
        {
            return a - b;
        }
        else
        {
            return a * b;
        }
    }

    private static void Main(string[] args)
    {
        int a = 2;
        int b = 15;
        int h = 1;
        int y;

        for (int x = a; x <= b; x += h)
        {
            y = f(x, a, b);
            Console.WriteLine($"y = {y}");
        }
    }
}
