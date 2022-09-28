class Program
{
    static void Main()
    {
        int[] items = { 1, 2, 5, 7, 10, 12, 55, 101, 300, 115 };
        foreach (var i in Expect(items, 5))
        {
            Console.Write(i);
            Console.Write(" ");
        }
    }
    static int[] Expect(int[] arr, int val)
    {
        int x = 0; // this is helper variable
        int y;
        foreach (int i in arr)
        {
            y = i;
            while (y >= val)//here is a count of the number of times the recevied number is in array
            {
                if (y == val || y % 10 == val)
                {
                    x++;
                    break;
                }
                y = y / 10;
            }

        }


        int[] contains = new int[x];
        x = 0;// this is reuse of helper variable
        y = 0;// this is reuse of helper variable

        foreach (var i in arr)
        {
            y = i;
            while (y >= val)//here is a count of the number of times the recevied number is in array
            {
                if (y == val || y % 10 == val)
                {
                    contains[x] = i;
                    x++;
                    break;
                }
                y = y / 10;
            }
        }
        return contains;
    }
}