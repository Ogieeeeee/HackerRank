public static class WarmUpChallenges
{

    // ar = [10, 20, 20, 10, 10, 30, 50, 10, 20]
    // output = 3
    public static int SockMerchant(int n, List<int> ar)
    {
        int result = 0;

        for (int i = 0; i < ar.Count - 1; i++)
        {
            if (ar[i] == -1) continue;

            for (int j = i + 1; j < ar.Count; j++)
            {
                if (ar[i] == ar[j])
                {
                    ar[i] = -1;
                    ar[j] = -1;
                    result++;
                    break;
                }
            }
        }
        return result;
    }

    public static int CountingValleys(int steps, string path)
    {
        int seaLevel = 0;
        int prevSeaLevel = 0;
        int result = 0;
        for (int i = 0; i < path.Length; i++)
        {
            if (path[i] == 'U')
                seaLevel++;
            else
                seaLevel--;

            if (i >= 1 && seaLevel == 0 && prevSeaLevel == -1)
                result++;

            prevSeaLevel = seaLevel;
        }

        return result;
    }

    public static int jumpingOnClouds(List<int> c)
    {
        int result = 0;
        double jumpcounter = 0;
        for (int i = 0; i < c.Count(); i++)
        {
            if (c[i] == 0)
            {
                jumpcounter += 1;
            }
            else
            {
                result += (int)Math.Ceiling((jumpcounter - 1) / 2) + 1;
                jumpcounter = 0;
            }
        }
        return result + (int)Math.Ceiling((jumpcounter - 1) / 2);
    }
}