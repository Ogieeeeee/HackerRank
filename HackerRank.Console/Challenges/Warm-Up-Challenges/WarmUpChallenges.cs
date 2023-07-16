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
}