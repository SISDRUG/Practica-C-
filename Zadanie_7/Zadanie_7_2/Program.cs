using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Inpute stroke");
        string s = Console.ReadLine();
        Regex html = new Regex(@" *<html>*");
        Regex form = new Regex(@" *<form>*");
        Regex h1 = new Regex(@" *<h1>*");
        MatchCollection matches_html = html.Matches(s);
        MatchCollection matches_h1 = h1.Matches(s);
        MatchCollection matches_form = form.Matches(s);
        if (matches_html.Count > 0 & matches_h1.Count > 0 & matches_form.Count > 0)
        {
            Console.WriteLine("Html code");
        }
        else
        {
            Console.WriteLine("Nan html code");
        }
        
    }
}