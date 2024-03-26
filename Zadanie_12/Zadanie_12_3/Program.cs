namespace Zadanie_12_3
{
    /// <summary>
    /// Delegate for string operations.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <returns>Modified string.</returns>
    public delegate string Del(string str);

    class Program
    {
        /// <summary>
        /// Concatenates the input string with itself.
        /// </summary>
        /// <param name="str">Input string.</param>
        /// <returns>Concatenated string.</returns>
        static string Concatenation(string str)
        {
            string result = str + str;
            Console.WriteLine(result);
            return result;
        }

        /// <summary>
        /// Removes the last character from the input string.
        /// </summary>
        /// <param name="str">Input string.</param>
        /// <returns>Modified string.</returns>
        static string RemoveLastElement(string str)
        {
            string result = str.Remove(str.Length - 1);
            Console.WriteLine(result);
            return result;
        }

        /// <summary>
        /// Converts the input string to lowercase.
        /// </summary>
        /// <param name="str">Input string.</param>
        /// <returns>Modified string.</returns>
        static string ToLowerCase(string str)
        {
            string result = str.ToLower();
            Console.WriteLine(result);
            return result;
        }

        static void Main(string[] args)
        {
            string str = "ZXC";

            Del del = new Del(Concatenation);
            del += RemoveLastElement;
            del += ToLowerCase;

            del(str);
        }
    }
}