class Program
{
    static void Main()
    {
        int[] arr = { 37, 4, 8, 54, 8, 4, 8, 4 };
        int[] newArr = new int[arr.Length + 1];
        for (int i = 0; i < newArr.Length; i++)
        {
            newArr[i] = Add(arr, 3)[i];
            Console.Write(newArr[i]);
            if (i != newArr.Length - 1)
                Console.Write(", ");
        }
    }
    static int[] Add(int[] getArr, int getAdd)
    {
        if (getArr.Length == 0 || getArr == null)
        {
            int[] addNum = { getAdd };
            return (
                addNum
                );
        }
        int[] add = new int[getArr.Length + 1];

        for (int i = 0; i < getArr.Length; i++)
        {
            add[i] = getArr[i];
        }
        add[getArr.Length] = getAdd;

        return add;

    }
}
