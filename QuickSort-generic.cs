class Algo_Sort_QuickSort<T> where T : IComparable
{
    static int num_compare = 0;
    static int num_exch = 0;

    public static void Run(T[] items)
    {
        Stopwatch sp = new Stopwatch();
        sp.Start();
        QuickSort(items);
        sp.Stop();
        Console.WriteLine(string.Format("quick sort: {0} ms",sp.ElapsedMilliseconds));
        Console.WriteLine(string.Format("compared: {0}", num_compare));
        Console.WriteLine(string.Format("exchanged: {0}", num_exch));
        Console.WriteLine();
    }

    static void QuickSort(T[] items)
    {
        QuickSort(items, 0, items.Count()-1);
    }

    static void QuickSort(T[] items, int lo, int hi)
    {
        if (lo >= hi) return;

        var partition = lo;
        var pValue = items[lo];
        var i = lo;
        var j = hi;
        while(true)
        {
            while (i < j && !GreaterThan(items[i], pValue))
                i++;

            while (j >= i && GreaterThan(items[j], pValue))
                j--;
            
            if (j <= i) break;
            Exch(items, i, j);
        }
        Exch(items, partition, j);
        QuickSort(items, lo, j - 1);
        QuickSort(items, j + 1, hi);
    }

    static void Exch(T[] items, int i, int j)
    {
        if (i == j) return;
        num_exch++;
        var temp = items[i];
        items[i] = items[j];
        items[j] = temp;
    }

    static bool LessThan(T i, T j)
    {
        num_compare++;
        var result = i.CompareTo(j);
        if (result == -1) return true;
        return false;
    }
    static bool GreaterThan(T i, T j)
    {
        num_compare++;
        if (i.CompareTo(j) == 1) return true;
        return false;
    }
}
