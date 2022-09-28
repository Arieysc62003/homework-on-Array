class Program
{
    static void Main()
    {
        int[] array = { 2, 4, 6, 8, 6, 0, 13, 5, 7, 9, 6 };
        for (int i = 0; i < GetIndexes(array, 6).Length; i++)
        /*I could put the receivded array into to new array
         for example in previous exercise but in this exercise
          to decide that not*/
        {
            Console.Write(GetIndexes(array, 6)[i]);
            if (i != GetIndexes(array, 6).Length - 1)
                Console.Write(", ");
        }
    }

    static int[] GetIndexes(int[] arr, int num)
    {
        int x = 0; // this is helper variable
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)//here is a count of the number of times the recevied number is in array
            {
                x++;
            }
        }
        int[] index = new int[x];
        x = 0;// this is reuse of helper variable 
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                index[x] = i;
                x++;
            }
        }

        return index;
    }

}