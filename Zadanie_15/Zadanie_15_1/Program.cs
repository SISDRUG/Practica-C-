internal class Program
{
    public class MyList<T>
    {
        private readonly List<T> _list;

        public MyList()
        {
            _list = new List<T>();
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public T this[int index]
        {
            get { return _list[index]; }
        }

        public int Count
        {
            get { return _list.Count; }
        }
    }

    private static void Main(string[] args)
    {
        MyList<int> myList = new MyList<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        Console.WriteLine(myList[0]);
        Console.WriteLine(myList.Count); 
    }
}