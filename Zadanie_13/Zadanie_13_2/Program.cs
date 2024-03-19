
using Zadanie_13_2;
internal class Program
{
    public static void Main(string[] args)
    {
        MyInfo info = new MyInfo("Max");
        info.NameChanged += Info_NameChanged;
        info.Name = "Den";
        info.Name = "Jan";
    }

    private static void Info_NameChanged(object sender, EventArgs e)
    {
        Console.WriteLine("Имя было изменено");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}