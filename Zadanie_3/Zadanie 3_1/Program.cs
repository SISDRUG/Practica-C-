internal class Program
{
    /// <summary>
    /// Calculates the value of the function f(x) = cos(2x) + sin(x - 3).
    /// </summary>
    /// <param name="x">The input value.</param>
    /// <returns>The value of the function at the specified point.</returns>
    public static double fun(double x)
    {
        return Math.Cos(2 * x) + Math.Sin(x - 3);
    }

    private static void Main(string[] args)
    {
        double a = 3;
        double b = 7;
        string res;
        Console.WriteLine($"Point f({a}) = {fun(a)}");
        Console.WriteLine($"Point f({b}) = {fun(b)}");
        if (fun(a) < fun(b)) { res = "a"; } else { res = "b"; }
        Console.WriteLine($"Point {res} has the smallest value.");
    }
}
