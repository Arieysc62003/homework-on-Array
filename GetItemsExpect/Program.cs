class Program
{
    static void Main()
    {
        int[] items = { 3, 9, 4, 9, 4, 8, 7, 1, 4 };
        foreach (var i in Expect(items, 9))
        {
            Console.Write(i);
            Console.Write(" ");
        }
    }
    static int[] Expect(int[] arr, int val)
    {
        int x = 0; // this is helper variable
        foreach (var i in arr)
        {
            if (i != val)//here is a count of the number of times the recevied number is in array
            {
                x++;
            }
        }


        int[] ecp = new int[x];
        x = 0;// this is reuse of helper variable

        foreach (var i in arr)
        {
            if (i != val)
            {
                ecp[x] = i;
                x++;
            }
        }
        return ecp;
    }
}