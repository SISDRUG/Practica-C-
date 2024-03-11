Console.WriteLine("Input text");
string s = Console.ReadLine();
string[] spl = s.Split(' ');
for (int i = spl.Length - 1; i >= 0; i--)
{
    if (spl[i] != "")
    {
        Console.Write($"{spl[i]} ");
        }
    }
    
