
namespace Main
{
    struct Aeroflot
    {
        public string Destination;
        public int Number;
        public string Type;
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int num = 7;
            Aeroflot[] aeroflot = new Aeroflot[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Input {i + 1}:");

                Console.Write("Destination: ");
                aeroflot[i].Destination = Console.ReadLine();

                Console.Write("Number: ");
                aeroflot[i].Number = int.Parse(Console.ReadLine());

                Console.Write("Type: ");
                aeroflot[i].Type = Console.ReadLine();
            }

            Array.Sort(aeroflot, (a, b) => string.Compare(a.Destination, b.Destination));
            foreach (var flight in aeroflot)
            {
                Console.WriteLine($"Destination: {flight.Destination}, number: {flight.Number}, type {flight.Type}");
            }
            Console.WriteLine("\nSpecific type :");
            Console.Write("input type: ");
            string inputType = Console.ReadLine();
            
            bool found = false;
            foreach (var flight in aeroflot)
            {
                if (flight.Type == inputType)
                {
                    Console.WriteLine($"Destination: {flight.Destination}, number: {flight.Number}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Not found.");
            }
        }
    }
}
