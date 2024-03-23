namespace Zadanie_17_2_dll;

using System;

public interface IShootable
{
    void Shoot(Player target, int x);
}

public class Player : IShootable
{
    public int Hp { get; private set; } = 100;
    public string Name { get; private set; }
    public string Status { get; private set; } = "alive";
    public int Score { get; private set; } = 0;

    public Player(string name)
    {
        Name = name;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Name: {Name}, Hp: {Hp}, Status: {Status}, Score: {Score}");
    }

    public void Shoot(Player target, int x = 1)
    {
        for (int i = 0; i < x; i++)
        {
            if (this.Status != "alive" || target.Status != "alive")
            {
                Console.WriteLine($"{this.Name} cannot shoot {target.Name} because one of them is not alive.");
                return;
            }

            Random rand = new Random();
            int damage = rand.Next(5, 26);


            if (target.Hp <= damage)
            {
                target.Hp = 0;
                target.Status = "dead";
            }
            else
            {
                this.Score += 10;
                target.Hp -= damage;
            }
        }
    }
}
