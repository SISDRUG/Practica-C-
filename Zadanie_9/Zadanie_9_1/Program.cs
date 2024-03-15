internal class Program
{
    class cl : Ix, Iy, Iz
    {
        public string str = "ccc";

        public void IxF0(string s)
        {
            str = str + s.Remove(s.Length - 2);
            Console.WriteLine(str);
        }

        public void IxF1()
        {
            str = str.Insert(0, "aa");
            str = str.Remove(str.Length - 2);
            Console.WriteLine(str);
        }

        public void F0(string s) => Console.WriteLine((str + s).Remove(0, 2));
        public void F1() => Console.WriteLine(str.Remove(0, 2));

        void Iz.F0(string s) => Console.WriteLine('-' + (str + s));
        void Iz.F1() => Console.WriteLine('-' + str);

    }
    interface Ix
    {
        void IxF0(string s);
        void IxF1();
    }

    interface Iy
    {
        void F0(string s);
        void F1();
    }

    interface Iz
    {
        void F0(string s);
        void F1();
    }

    private static void Main(string[] args)
    {
        cl cl = new cl();
        cl.IxF0("bbbaa");
        cl.IxF1();
        cl.F0("ee");
        cl.F1();
        (cl as Iz).F0("kk");
        (cl as Iz).F1();
    }
}