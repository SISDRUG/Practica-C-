using System;

// Define the GumballMachine states using an interface
public interface IGumballState
{
    void InsertQuarter();
    void EjectQuarter();
    void TurnCrank();
    void Dispense();
}

// Implement the SoldState
public class SoldState : IGumballState
{
    private readonly GumballMachine gumballMachine;

    public SoldState(GumballMachine machine)
    {
        gumballMachine = machine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("Please wait, we're already giving you a gumball.");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Sorry, you already turned the crank.");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Turning twice doesn't get you another gumball!");
    }

    public void Dispense()
    {
        gumballMachine.ReleaseBall();
        if (gumballMachine.GetCount() > 0)
        {
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }
        else
        {
            Console.WriteLine("Oops, out of gumballs!");
            gumballMachine.SetState(gumballMachine.GetSoldOutState());
        }
    }
}

// Implement the SoldOutState
public class SoldOutState : IGumballState
{
    private readonly GumballMachine gumballMachine;

    public SoldOutState(GumballMachine machine)
    {
        gumballMachine = machine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("Sorry, the machine is sold out.");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You haven't inserted a quarter.");
    }

    public void TurnCrank()
    {
        Console.WriteLine("No gumball dispensed.");
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed.");
    }
}

// Implement the NoQuarterState
public class NoQuarterState : IGumballState
{
    private readonly GumballMachine gumballMachine;

    public NoQuarterState(GumballMachine machine)
    {
        gumballMachine = machine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You inserted a quarter.");
        gumballMachine.SetState(gumballMachine.GetHasQuarterState());
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You haven't inserted a quarter.");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You need to insert a quarter first.");
    }

    public void Dispense()
    {
        Console.WriteLine("You need to pay first.");
    }
}

// Implement the HasQuarterState
public class HasQuarterState : IGumballState
{
    private readonly GumballMachine gumballMachine;

    public HasQuarterState(GumballMachine machine)
    {
        gumballMachine = machine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You inserted a quarter.");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Quarter returned.");
        gumballMachine.SetState(gumballMachine.GetNoQuarterState());
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned the crank...");
        gumballMachine.SetState(gumballMachine.GetSoldState());
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed.");
    }
}

// Implement the GumballMachine class
public class GumballMachine
{
    private int count; // Number of gumballs in the machine
    private IGumballState currentState;
    private readonly IGumballState soldState;
    private readonly IGumballState soldOutState;
    private readonly IGumballState noQuarterState;
    private readonly IGumballState hasQuarterState;

    public GumballMachine(int numGumballs)
    {
        count = numGumballs;
        soldState = new SoldState(this);
        soldOutState = new SoldOutState(this);
        noQuarterState = new NoQuarterState(this);
        hasQuarterState = new HasQuarterState(this);

        if (count > 0)
            currentState = noQuarterState;
        else
            currentState = soldOutState;
    }

    public void InsertQuarter()
    {
        currentState.InsertQuarter();
    }

    public void EjectQuarter()
    {
        currentState.EjectQuarter();
    }

    public void TurnCrank()
    {
        currentState.TurnCrank();
        currentState.Dispense();
    }

    public void SetState(IGumballState state)
    {
        currentState = state;
    }

    public IGumballState GetSoldOutState()
    {
        return soldOutState;
    }

    public IGumballState GetSoldState()
    {
        return soldState;
    }

    public IGumballState GetNoQuarterState()
    {
        return noQuarterState;
    }

    public IGumballState GetHasQuarterState()
    {
        return hasQuarterState;
    }

    public void ReleaseBall()
    {
        if (count > 0)
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            count--;
        }
    }

    public int GetCount()
    {
        return count;
    }
}


class Program
{
    static void Main(string[] args)
    {
        GumballMachine gumballMachine = new GumballMachine(5);

        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();

        Console.WriteLine("\n---");

        gumballMachine.InsertQuarter();
        gumballMachine.EjectQuarter();
        gumballMachine.TurnCrank();

        Console.WriteLine("\n---");

        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();

        Console.WriteLine("\n---");

        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
    }
}
