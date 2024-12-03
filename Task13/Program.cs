
using System.Collections;

internal class Program
{
    static void Main(string[] args)
    {
        // 1- ArrayList
        Console.WriteLine("ArayList:");
        ArrayList arraylist = new ArrayList();
        arraylist.Add(1);
        arraylist.Add(2);
        arraylist.Insert(1, 2);
        arraylist.Remove(1);
        foreach (var list1 in arraylist)
        {
            Console.WriteLine(list1);
        }


        //2- List
        Console.WriteLine("List<T>:");
        List<int> list = new List<int> { 30, 40, 50 };
        list.AddRange(new int[] { 10, 20 });
        list.Sort();
        list.RemoveAt(2);
        foreach (var num in list)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();


        // 3 - Dictionary<TKey, TValue>
        Console.WriteLine("Dictionary<TKey, TValue>:");
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary.Add("erti", 1);
        dictionary.Add("ori", 2);
        dictionary.Add("sami", 3);
        dictionary.Remove("ori");
        foreach (var key in dictionary.Keys)
        {
            Console.WriteLine($"Key: {key}, Value: {dictionary[key]}");
        }
        Console.WriteLine();


        // 4 - SortedList<TKey, TValue>
        Console.WriteLine("SortedList<TKey, TValue>:");
        SortedList<int, string> sortedList = new SortedList<int, string>();
        sortedList.Add(2, "ori");
        sortedList.Add(1, "erti");
        sortedList.Add(3, "sami");
        sortedList.RemoveAt(0);
        foreach (var key in sortedList.Keys)
        {
            Console.WriteLine($"Key: {key}, Value: {sortedList[key]}");
        }
        Console.WriteLine();

        // 5 - Stack<T>
        Console.WriteLine("Stack<T>:");
        Stack<string> stack = new Stack<string>();
        stack.Push("Nana");
        stack.Push("Diko");
        stack.Push("Eka");
        Console.WriteLine($"Lifo Peek: {stack.Peek()}");
        stack.Pop(); // Remove the top element
        foreach (var name in stack)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();


        // 6 - Queue<T>
        Console.WriteLine("Queue<T>:");
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine($"Fifo Peek: {queue.Peek()}");
        queue.Dequeue();
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();


        // 7 - SortedDictionary<TKey, TValue>
        Console.WriteLine("SortedDictionary<TKey, TValue>:");
        SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
        sortedDictionary.Add(3, "Three");
        sortedDictionary.Add(7, "Seven");
        sortedDictionary.Add(5, "Five");
        sortedDictionary.Remove(2);
        foreach (var key in sortedDictionary.Keys)
        {
            Console.WriteLine($"Key: {key}, Value: {sortedDictionary[key]}");
        }
        Console.WriteLine();


        // 8 - HashSet<T>
        Console.WriteLine("HashSet<T>:");
        HashSet<int> hashSet = new HashSet<int>();
        hashSet.Add(1);
        hashSet.Add(2);
        hashSet.Add(3);
        HashSet<int> anotherSet = new HashSet<int> { 3, 4, 5 };
        hashSet.UnionWith(anotherSet);
        foreach (var item in hashSet)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

    }
}

