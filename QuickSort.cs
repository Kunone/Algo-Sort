class Algo_Sort_QuickSort
{
    public static void Run(int[] items)
    {
        Stopwatch sp = new Stopwatch();
        sp.Start();
        QuickSort(items);
        sp.Stop();
        Console.WriteLine(string.Format("quick sort: {0} ms",sp.ElapsedMilliseconds));
    }

    static void QuickSort(int[] items)
    {
        QuickSort(items, 0, items.Count()-1);
    }

    static void QuickSort(int[] items, int i, int j)
    {
        if (i >= j) return;

        var partition = i;
        var lo = i;
        var hi = j;
        while(true)
        {
            while (i <= j && items[i] <= items[partition]) i++;
            while (j >= i && items[j] > items[partition]) j--;
            if (j < i) break;
            Exch(items, i, j);
        }
        Exch(items, partition, j);
        QuickSort(items, lo, j - 1);
        QuickSort(items, j + 1, hi);
    }

    static void Exch(int[] items, int i, int j)
    {
        var temp = items[i];
        items[i] = items[j];
        items[j] = temp;
    }
}
