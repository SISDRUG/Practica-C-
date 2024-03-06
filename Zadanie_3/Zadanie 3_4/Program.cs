internal class Program
{

    public class StringMatr
    {
        string[,] stmatr;
        int row;
        int col;

        public StringMatr()
        {

        }

        public void size(int row, int col)
        {
            this.stmatr = new string[row, col];
            this.row = row;
            this.col = col;
        }

        public StringMatr(StringMatr matr)
        {
            this.stmatr = matr.stmatr;
            this.row = matr.row;
            this.col = matr.col;
        }



        public StringMatr(int row, int col, string stroke)
        {
            this.row = row;
            this.col = col;
            this.stmatr = new string[row,col];
            string[] cells = stroke.Split(';');
            int c = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    this.stmatr[i, j] = cells[c] ;
                    c++;
                }
            }
            
        }

        public StringMatr(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.stmatr = new string[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine($"Input cell [{i},{j}]");
                    this.stmatr[i, j] = Console.ReadLine();

                }
            }

        }

        public static StringMatr operator + (StringMatr f , StringMatr s)
        {
            StringMatr r = new();
            r.size(f.row,f.col);
            for (int i = 0; i < f.row; i++)
            {
                for (int j = 0; j < f.col ; j++)
                {
                    r.stmatr[i,j] = f.stmatr[i,j] + s.stmatr[i,j];
                }
            }
            return r;
        }

        public void Print()
        {
            for (int i = 0; i < this.row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < this.col; j++)
                {
                    Console.Write($"{stmatr[i,j]} ");
                }
            }
        }
    }

    private static void Main(string[] args)
    {
        StringMatr stringMatr = new(3, 3,"a;a;a;b;b;b;c;c;c");
        //StringMatr str = new(3, 3);
        StringMatr f = new(3, 3, "a;a;a;b;b;b;c;c;c");
        StringMatr s = new(3, 3, "b;b;b;c;c;c;a;a;a");
        StringMatr t = f + s;
        t.Print();
        (f + s).Print();
        //str.Print();
        //stringMatr.Print();
    }
}