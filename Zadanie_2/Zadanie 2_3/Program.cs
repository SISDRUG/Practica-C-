using System;

public class Vector
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Vector(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public Vector Add(Vector v)
    {
        return new Vector(X + v.X, Y + v.Y, Z + v.Z);
    }

    public Vector Subtract(Vector v)
    {
        return new Vector(X - v.X, Y - v.Y, Z - v.Z);
    }

    public double DotProduct(Vector v)
    {
        return X * v.X + Y * v.Y + Z * v.Z;
    }

    public double Length()
    {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    public double Cosine(Vector v)
    {
        return DotProduct(v) / (Length() * v.Length());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector(1, 2, 3);
        Vector v2 = new Vector(4, 5, 6);

        Vector sum = v1.Add(v2);
        Console.WriteLine($"Sum: {sum.X}, {sum.Y}, {sum.Z}");

        Vector diff = v1.Subtract(v2);
        Console.WriteLine($"Difference: {diff.X}, {diff.Y}, {diff.Z}");

        double dot = v1.DotProduct(v2);
        Console.WriteLine($"Dot Product: {dot}");

        double len = v1.Length();
        Console.WriteLine($"Length: {len}");

        double cos = v1.Cosine(v2);
        Console.WriteLine($"Cosine: {cos}");
    }
}
