internal class Program
{
    public class NonFunctionalRangeException : Exception
    {
        public NonFunctionalRangeException(String message)
            : base(message)
        {

        }
    }

    static void Validator(double x)
    {
        if (x < -4)
        {
            throw new NonFunctionalRangeException($"{x} is out of calculatable range");
        }
    }

    private static void Main(string[] args)
    {

        double a = 0;
        double b = 0;

        
        Console.WriteLine("Input a");
        try
        {
            a = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException) { Console.WriteLine("Error format use unseparated digits only and '-' !"); }

        Console.WriteLine("Input b");
        try
        {
            b = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException) { Console.WriteLine("Error format use unseparated digits only and '-' !"); }

        for (double x = a; x < b; x++)
        {
            try
            {
                Validator(x);
                if (x<1)
                {
                    Console.WriteLine($"f({x}) = {(3*x)/(x-2)}");
                }
                else
                {
                    Console.WriteLine($"f({x}) = 3");
                }
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException($"computing with {x} include divide by zero exception");
            }
        }

    }
}