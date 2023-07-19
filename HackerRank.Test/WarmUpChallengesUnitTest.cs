namespace HackerRank.Test;

public class WarmUpChallengesUnitTest
{
    public static IEnumerable<Object[]> CountingValleysTestData = new List<Object[]>()
    {
        new Object[]{11, new List<int> { 1, 2, 1, 3, 1, 4, 5, 6, 6, 7, 1 }, 3},
        new Object[]{ 6, new List<int> { 1, 1,2,2,5,6 }                    ,2},
        new Object[]{10, new List<int> { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4}     ,3},
    };

    [Theory]
    [MemberData(nameof(CountingValleysTestData))]
    public void SockMerchantTest(int count, List<int> testData, int expected)
    {
        int actual = WarmUpChallenges.SockMerchant(count, testData);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(8, "UDDDUDUU", 1)]
    [InlineData(12, "DDUUDDUDUUUD", 2)]
    public void CountingValleysTest(int steps, string path, int expected)
    {
        int actual = WarmUpChallenges.CountingValleys(steps, path);

        Assert.Equal(expected, actual);
    }

    public static IEnumerable<Object[]> JumpingOnCloudsTestData = new List<Object[]>()
    {
        new Object[]{new List<int> { 0, 0, 0, 1, 0, 0, 0 }, 3},
        new Object[]{new List<int> { 0, 0, 1, 0, 0 ,0 }   , 3},
        new Object[]{new List<int> { 0, 1, 0, 1, 0}       , 2},
        new Object[]{new List<int> { 0, 0, 0, 0, 0, 0}    , 3},
    };

    [Theory]
    [MemberData(nameof(JumpingOnCloudsTestData))]
    public void JumpingOnCloudsTest(List<int> c, int expected)
    {
        int actual = WarmUpChallenges.jumpingOnClouds(c);

        Assert.Equal(expected, actual);
    }
}