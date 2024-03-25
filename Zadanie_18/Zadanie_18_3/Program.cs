public class MyCustomList<T> : ICloneable
{
    private T[] items;

    public MyCustomList()
    {
        items = new T[0];
    }

    public void Add(T item)
    {
        Array.Resize(ref items, items.Length + 1);
        items[items.Length - 1] = item;
    }

    public void Remove(T item)
    {
        int index = Array.IndexOf(items, item);
        if (index >= 0)
        {
            for (int i = index; i < items.Length - 1; i++)
            {
                items[i] = items[i + 1];
            }
            Array.Resize(ref items, items.Length - 1);
        }
    }

    public int Count => items.Length;

    public T this[int index]
    {
        get
        {
            if (index >= 0 && index < items.Length)
            {
                return items[index];
            }
            throw new IndexOutOfRangeException();
        }
        set
        {
            if (index >= 0 && index < items.Length)
            {
                items[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    public object Clone()
    {
        MyCustomList<T> clonedList = new MyCustomList<T>();
        foreach (var item in items)
        {
            clonedList.Add(item);
        }
        return clonedList;
    }
}

public class MyCustomDictionary<TKey, TValue> : ICloneable
{
    private const int InitialCapacity = 16;
    private LinkedList<KeyValuePair<TKey, TValue>>[] buckets;

    public MyCustomDictionary()
    {
        buckets = new LinkedList<KeyValuePair<TKey, TValue>>[InitialCapacity];
    }

    private int GetBucketIndex(TKey key)
    {
        int hashCode = key.GetHashCode();
        return Math.Abs(hashCode) % buckets.Length;
    }

    public void Add(TKey key, TValue value)
    {
        int bucketIndex = GetBucketIndex(key);
        if (buckets[bucketIndex] == null)
        {
            buckets[bucketIndex] = new LinkedList<KeyValuePair<TKey, TValue>>();
        }

        foreach (var pair in buckets[bucketIndex])
        {
            if (pair.Key.Equals(key))
            {
                throw new ArgumentException("Key already exists in the dictionary.");
            }
        }

        buckets[bucketIndex].AddLast(new KeyValuePair<TKey, TValue>(key, value));
    }

    public bool TryGetValue(TKey key, out TValue value)
    {
        int bucketIndex = GetBucketIndex(key);
        if (buckets[bucketIndex] != null)
        {
            foreach (var pair in buckets[bucketIndex])
            {
                if (pair.Key.Equals(key))
                {
                    value = pair.Value;
                    return true;
                }
            }
        }

        value = default(TValue);
        return false;
    }

    public bool ContainsKey(TKey key)
    {
        int bucketIndex = GetBucketIndex(key);
        if (buckets[bucketIndex] != null)
        {
            foreach (var pair in buckets[bucketIndex])
            {
                if (pair.Key.Equals(key))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public TValue this[TKey key]
    {
        get
        {
            if (TryGetValue(key, out TValue value))
            {
                return value;
            }
            throw new KeyNotFoundException($"Key '{key}' not found in the dictionary.");
        }
        set
        {
            Add(key, value);
        }
    }

    public object Clone()
    {
        MyCustomDictionary<TKey, TValue> clonedDictionary = new MyCustomDictionary<TKey, TValue>();

        foreach (var bucket in buckets)
        {
            if (bucket != null)
            {
                foreach (var pair in bucket)
                {
                    clonedDictionary.Add(pair.Key, pair.Value);
                }
            }
        }

        return clonedDictionary;
    }
}


public class Diary
{
    private MyCustomDictionary<DateTime, MyCustomList<string>> entries;

    public Diary()
    {
        entries = new MyCustomDictionary<DateTime, MyCustomList<string>>();
    }

    public void AddEntry(DateTime date, string entry)
    {
        if (!entries.ContainsKey(date))
        {
            entries[date] = new MyCustomList<string>();
        }
        entries[date].Add(entry);
    }

    public MyCustomList<string> GetEntries(DateTime date)
    {
        if (entries.ContainsKey(date))
        {
            return entries[date];
        }
        return new MyCustomList<string>();
    }

    
}

class Program
{
    static void Main()
    {
        Diary myDiary = new Diary();

        myDiary.AddEntry(new DateTime(2024, 3, 25), "Поход в парк");
        myDiary.AddEntry(new DateTime(2024, 3, 25), "Встреча с друзьями");
        myDiary.AddEntry(new DateTime(2024, 3, 26), "Учеба");

        MyCustomList<string> entriesForMarch25 = myDiary.GetEntries(new DateTime(2024, 3, 25));
        Console.WriteLine("Записи на 25 марта:");
        for (int i = 0; i < entriesForMarch25.Count; i++)
        {
            Console.WriteLine(entriesForMarch25[i]);
        }
    }
}
