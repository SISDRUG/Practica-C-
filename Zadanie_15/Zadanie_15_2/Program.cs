internal class Program
{
    public class MyDictionary<TKey, TValue>
    {
        private Dictionary<TKey, TValue> _dictionary;

        public MyDictionary()
        {
            _dictionary = new Dictionary<TKey, TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            _dictionary.Add(key, value);
        }

        public TValue this[TKey key]
        {
            get { return _dictionary[key]; }
        }

        public int Count
        {
            get { return _dictionary.Count; }
        }
    }

    private static void Main(string[] args)
    {
        MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
        myDictionary.Add("one", 1);
        myDictionary.Add("two", 2);
        myDictionary.Add("three", 3);
        Console.WriteLine(myDictionary["one"]) ;
        Console.WriteLine(myDictionary.Count);
    }
}