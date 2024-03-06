internal class Program
{

    public static double fun(double x)
    {
        return Math.Cos(2*x)+ Math.Sin(x-3) ;
    }
    private static void Main(string[] args)
    {
        double a = 3;
        double b = 7;
        string res;
        Console.WriteLine($"Tochka f({a}) = {fun(a)}");
        Console.WriteLine($"Tochka f({b}) = {fun(b)}");
        if (fun(a) < fun(b)) { res = "a"; } else { res = "b"; }
        Console.WriteLine($"Tochka {res} naimensheya");
    }
}