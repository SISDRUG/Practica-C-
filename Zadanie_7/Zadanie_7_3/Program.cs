using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input stroke");
        string s = Console.ReadLine();
        Regex regex = new Regex(@"\d");
        MatchCollection matches = regex.Matches(s);

        if (matches.Count > 0)
        {
            Console.WriteLine("include digits");
        }
        else
        {
            Console.WriteLine("no digits");
        }
    }
}