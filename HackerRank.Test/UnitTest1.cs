namespace HackerRank.Test;

public class UnitTest1
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Test1(int count, List<int> testData, int expected)
    {
        int actual = WarmUpChallanges.SockMerchant(count, testData);

        Assert.Equal(expected, actual);
    }

    public static IEnumerable<Object[]> Data = new List<Object[]>()
    {
        new Object[]{11, new List<int> { 1, 2, 1, 3, 1, 4, 5, 6, 6, 7, 1 }, 3},
        new Object[]{ 6, new List<int> { 1, 1,2,2,5,6 }                    ,2},
        new Object[]{10, new List<int> { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4}     ,3},
    };
}