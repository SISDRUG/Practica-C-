internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string[] words = Console.ReadLine().Split(' ');
            string f = words[0];
            words[0] = words[words.Length - 1];
            words[words.Length - 1] = f;
            Console.Write($"{string.Join(" ", words)}");
            words[2] = words[1] + words[2];
            words[1]= "";
            Console.WriteLine();
            Console.Write($"{string.Join(" ", words)}");
            char[] word2 = words[2].ToCharArray();
            Array.Reverse(word2);
            words[2] = new string (word2);                  
            Console.WriteLine();
            Console.Write($"{string.Join(" ", words)}");
            words[0] = words[0].Substring(2);
            Console.WriteLine();
            Console.Write($"{string.Join(" ", words)}");
        }
    }

