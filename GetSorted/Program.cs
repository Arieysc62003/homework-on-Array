class Program
{
    static void Main()
    {
        int[] items = { 8, 3, 9, 1, 0, 3, 7, 3, 6 };
        foreach (var i in Sorted(items))
        {
            Console.Write(i);
            Console.Write(" ");
        }
    }

    static int[] Sorted(int[] arr)
    {
        int helped;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int w = i + 1; w < arr.Length; w++)
            {
                if (arr[i] > arr[w])
                {
                    helped = arr[i];
                    arr[i] = arr[w];
                    arr[w] = helped;
                }
            }
        }
        return arr;
    }
}