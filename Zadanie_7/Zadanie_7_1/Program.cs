using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input stroke");
        string s = Console.ReadLine();
        Regex regex = new Regex(@"\b\w+-\w+\b");
        MatchCollection matches = regex.Matches(s);

        if (matches.Count > 0)
        {
            foreach (Match match in matches)
                Console.WriteLine(match.Value);
        }
    }
}