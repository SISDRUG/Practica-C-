using System;
using System.Linq;

public class Train : IComparable<Train>
{
    public string Destination { get; private set; }
    public string Number { get; private set; }
    public DateTime Time { get; private set; }

    public Train(string destination, string number, DateTime time)
    {
        Destination = destination;
        Number = number;
        Time = time;
    }

    public int CompareTo(Train other)
    {
        return Time.CompareTo(other.Time);
    }
}

public class Station
{
    private Train[] trains;

    public Station(Train[] trains)
    {
        this.trains = trains;
    }

    public Train this[string number]
    {
        get { return trains.FirstOrDefault(t => t.Number == number); }
    }

    public Train[] GetTrainsDepartingAfter(DateTime time)
    {
        return trains.Where(t => t.Time > time)
                     .ToArray();
    }

    public Train[] GetTrainsToDestination(string destination)
    {
        return trains.Where(t => t.Destination == destination)
                     .OrderBy(t => t.Time)
                     .ToArray();
    }
}

class Program
{
    static void Main()
    {
        var trains = new Train[]
        {
            new Train("Minsk", "123A", new DateTime(2024, 3, 14, 14, 0, 0)),
            new Train("Brest", "456B", new DateTime(2024, 3, 14, 16, 0, 0)),
            new Train("Grodno", "789C", new DateTime(2024, 3, 14, 18, 0, 0))
        };

        var station = new Station(trains);

        Console.WriteLine(station["123A"].Destination);

        var lateTrains = station.GetTrainsDepartingAfter(new DateTime(2024, 3, 14, 17, 0, 0));
        foreach (var train in lateTrains)
            Console.WriteLine(train.Number);

        var trainsToMinsk = station.GetTrainsToDestination("Minsk");
        foreach (var train in trainsToMinsk)
            Console.WriteLine(train.Number);
    }
}
