// 2610. Convert an Array Into a 2D Array With Conditions
public class Solution {
    public IList<IList<int>> FindMatrix(int[] nums)
    {
        List<IList<int>> result = new()
        {
            new List<int>()
        };

        int[] frequency = new int[nums.Length + 1];
        int maxFrequency = 0;

        foreach (int num in nums)
        {
            int currentFrequency = frequency[num]++;

            if (currentFrequency > maxFrequency)
            {
                maxFrequency = currentFrequency;
                result.Add(new List<int> { num });
            }
            else
            {
                result[currentFrequency].Add(num);
            }
        }

        return result;
    }
}
