class Algo_Sort_Main
{
    static void Main(string[] args)
    {
        var items2 = GenerateArray(10000);

        //var items2 = new string[] { "H", "A", "C", "B", "F", "E", "G", "D", "L", "I", "K", "J", "N", "M", "O" };
        //var items3 = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O" };
        
        Algo_Sort_QuickSort<Int64>.Run(items2);
        if (items2.Length < 100)
            Print(items2);

        Algo_Sort_QuickSort<Int64>.Run(items2);
        if (items2.Length < 100)
            Print(items2);

        Console.ReadKey();
    }

    static Int64[] GenerateArray(int length)
    {
        var items = new Int64[length];
        Random r = new Random();
        for (var i = 0; i < length; i++)
        {
            items[i] = r.Next(length);
        }

        return items;
    }

    static void Print<T>(T[] items)
    {
        foreach (var i in items)
            Console.Write(i + " ");
        Console.WriteLine();
    }
}
