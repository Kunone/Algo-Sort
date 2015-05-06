class Algo_Sort_MergeSort
{
    public static void Run(int[] items)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        MergeSort(items);
        sw.Stop();

        Console.WriteLine("Merge Sort2");
        Console.WriteLine("*******************************************");
        //Console.WriteLine("switched #{0}", num_switch);
        //Console.WriteLine("invoked self #{0}", num_invokeSelf);
        Console.WriteLine("spent #{0} ms", sw.ElapsedMilliseconds);
        Console.WriteLine();
        Console.WriteLine();
    }

    static void MergeSort(int[] items)
    {
        var aux = new int[items.Length];
        var lo = 0;
        var hi = items.Length - 1;
        MergeSort(items, aux, lo, hi);
    }

    static void MergeSort(int[] a, int[] aux, int lo, int hi)
    {
        var mid = ((hi - lo) / 2) + lo;
        if (lo >= hi) return;
        MergeSort(a, aux, lo, mid);
        MergeSort(a, aux, mid + 1, hi);
        if (a[mid] <= a[mid + 1]) return;
        Merge(a, aux, lo, mid, hi);
    }

    static void Merge(int[] a, int[] aux, int lo, int mid, int hi)
    {
        for (var k = lo; k <= hi; k++)
        {
            aux[k] = a[k];
        }
        int i = lo;
        int j = mid + 1;
        for (var k = lo; k <= hi; k++)
        {
            if (i > mid) a[k] = aux[j++];
            else if (j > hi) a[k] = aux[i++];
            else if (aux[i] <= aux[j]) a[k] = aux[i++];
            else a[k] = aux[j++];
        }
    }
}
