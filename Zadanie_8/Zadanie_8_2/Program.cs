enum Post
{
    Manager,      
    Engineer,     
    Technician    
}

class Accountant
{
    
    public bool AskForBonus(Post worker, int hours)
    {
        const int ManagerHours = 160;
        const int EngineerHours = 180;
        const int TechnicianHours = 200;

        switch (worker)
        {
            case Post.Manager:
                return hours > ManagerHours;
            case Post.Engineer:
                return hours > EngineerHours;
            case Post.Technician:
                return hours > TechnicianHours;
            default:
                throw new ArgumentException("Недопустимая должность");
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        
        Accountant accountant = new Accountant();

        Console.Write("Введите должность (Manager, Engineer, Technician): ");
        string inputPost = Console.ReadLine();
        Console.Write("Введите отработанные часы: ");
        int inputHours = int.Parse(Console.ReadLine());

        if (Enum.TryParse(inputPost, out Post post))
        {
            bool bonus = accountant.AskForBonus(post, inputHours);
            Console.WriteLine(bonus ? "Сотруднику положена премия" : "Сотруднику премия не положена");
        }
        else
        {
            Console.WriteLine("Недопустимая должность");
        }
    }
}
