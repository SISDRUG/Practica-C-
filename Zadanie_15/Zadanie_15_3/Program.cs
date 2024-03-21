using System;
using System.Collections.Generic;

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


        public T[] GetArray()
        {
            T[] array = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                array[i] = this[i];
            }
            return array;
        }
    }

    private static void Main(string[] args)
    {
        MyList<int> myList = new MyList<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        int[] array = myList.GetArray();

        //Console.Write();
        Console.Write("Get array:"+string.Join(",",array)+"."); 
    }
}
