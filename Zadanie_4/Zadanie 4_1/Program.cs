internal class Program
{

    
    private static void Main(string[] args)
    {
        int a = 0;
        int b = 0;

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
        catch (FormatException) { Console.WriteLine("Error format use digits only!"); }
       

        try
        {
            Console.WriteLine((5 * a -7)/(4*a+8));
        }
        catch (DivideByZeroException) { Console.WriteLine($"a = {a} create a infinity count by divide zero"); }

        try
        {
            Console.WriteLine(Math.Tan(b)+(Math.Cos(a)/(b-1)));
        }
        catch (DivideByZeroException) { Console.WriteLine($"a = {a} create a infinity count by divide zero"); }
    }
}