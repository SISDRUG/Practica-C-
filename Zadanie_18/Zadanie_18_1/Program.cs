class Program
{
    static void Main(string[] args)
    {
        string input = "abc#d##c";
        string result = backspace(input);
        Console.WriteLine("result: " + result);
    }

    static string backspace(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '#')
            {
                if (stack.Count > 0)
                    stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }

        char[] reversedArray = stack.ToArray();
        Array.Reverse(reversedArray);
        return new string(reversedArray);
    }
}
