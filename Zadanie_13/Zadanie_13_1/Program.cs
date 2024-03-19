using Zadanie_13_1;
internal class Program
{
    public static void WordHandler(object sender, WordEvent e)
    {
        Console.WriteLine("Получено слово: " + e.Word);
    }

    public delegate string WordDelegate();

    static void Main(string[] args)
    {
        WordProvider wordProvider = new WordProvider();
        wordProvider.WordGenerated += WordHandler;

        ExecuteWordDelegate(wordProvider.GetWords);

        Console.ReadLine();
    }

    public static void ExecuteWordDelegate(WordDelegate wordDelegate)
    {
        try
        {
            string words = wordDelegate.Invoke();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка:" + ex.Message);
        }
    }
}