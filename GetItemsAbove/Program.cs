class Program
{
    static void Main()
    {
        int[] a = { 3, 8, 3, 9, 4, 8, 3 };
        foreach (var i in Above(a, 5))
        {
            Console.Write(i);
            Console.Write(" ");
        }
    }

    static int[] Above(int[] arr, int num)
    {
        int x = 0; // this is helper variable
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > num)//here is a count of the number of times the recevied number is in array
            {
                x++;
            }
        }
        int[] above = new int[x];
        x = 0;// this is reuse of helper variable 
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > num)
            {
                above[x] = arr[i];
                x++;
            }
        }

        return above;
    }

}


