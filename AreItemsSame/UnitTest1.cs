using NUnit.Framework;

namespace AreItemsSame;

public class Tests
{

    bool Same(int[] arr)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[0] != arr[i])
            {
                return false;
            }
        }
        return true;
    }

    [TestCase(new int[] { 3, 73, 67, 3, 5 }, ExpectedResult = true)]
    [TestCase(new int[] { 2, 2, 2, 2, 2, 2, 2, 2 }, ExpectedResult = true)]
    [TestCase(new int[] { 1, 3, 1, 3, 1, 3 }, ExpectedResult = true)]
    [TestCase(new int[] { 4, 4, 4, 4, 4, 4, 4 }, ExpectedResult = true)]
    [TestCase(new int[] { }, ExpectedResult = true)]
    public bool Test(int[] arr)
    {
        return Same(arr);
    }
}


