internal class Program
{
    public class Matr
    {
        double[,] matr;
        int row;
        int col;

        public Matr()
        {

        }

        public double this[int row, int col]
        {
            get => matr[row, col];
            set => matr[row, col] = value;
        }

        public Matr(int row,int col)
        {
            this.matr = new double[row,col];
            this.col = col;
            this.row = row;
        }

        public  Matr(Matr c)
        {
            this.matr = (double[,])c.matr.Clone();
            this.row = c.row;
            this.col = c.col;
        }

        public static Matr operator + (Matr f, Matr s)
        {
            Matr r = new(f);
            for (int i = 0; i < f.row; i++)
            {
                for (int j = 0; j < f.col; j++)
                {
                    r[i, j] = f[i, j] + s[i,j];
                }
            }
            return r;
        }

        public static Matr operator + (Matr f, int s)
        {
            Matr r = new(f);
            for (int i = 0; i < f.row; i++)
            {
                for (int j = 0; j < f.col; j++)
                {
                    r[i, j] = f[i, j] + s;
                }
            }
            return r;
        }

        public static bool operator > (Matr f, Matr s)
        {
            if (f.row == s.row & f.col == s.col)
            {


                for (int i = 0; i < f.row; i++)
                {
                    for (int j = 0; j < f.col; j++)
                    {
                        if (f[i, j] < s[i, j])
                        {
                            return false;
                        }
                    }
                }

                return true;


            }

            return false;
            
        }
        public static bool operator <(Matr f, Matr s)
        {
            if (f.row == s.row & f.col == s.col)
            {


                for (int i = 0; i < f.row; i++)
                {
                    for (int j = 0; j < f.col; j++)
                    {
                        if (f[i, j] > s[i, j])
                        {
                            return false;
                        }
                    }
                }

                return true;


            }

            return false;

        }

        public void Print()
        {
            for (int i = 0; i < this.row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < this.col; j++)
                {
                    Console.Write($"{this[i,j]} ");
                }
            }
        }
    }

    private static void Main(string[] args)
    {
        Matr a = new(2, 2);
        Matr b = new(2, 2);
        int s = 2;
        int c = 2;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                a[i, j] = 1;
                b[i, j] = 2;
            }
        }

        

        (a + b).Print();
        Console.WriteLine();
        a.Print();
        Console.WriteLine();
        a += b;
        a.Print();
        Console.WriteLine();

        Console.WriteLine(a<b);

    }
}