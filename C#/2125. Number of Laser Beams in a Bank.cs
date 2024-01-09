// 2125. Number of Laser Beams in a Bank
public class Solution
{
    public int NumberOfBeams(string[] bank)
    {
        int current = CountOfOnes(bank[0], 0);
        int nextCount = 0;
        int result = 0;

        for (int i = 1; i < bank.Length; i++)
        {
            nextCount = CountOfOnes(bank[i], 0);
            if (nextCount != 0)
            {
                result += current * nextCount;
                current = nextCount;
            }
        }

        return result;
    }

    private int CountOfOnes(string row, int result)
    {
        foreach (char ch in row)
        {
            result += ch - '0';
        }
        return result;
    }
}