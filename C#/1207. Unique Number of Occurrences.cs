// 1207. Unique Number of Occurrences

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        int n = arr.Length;
        if(n == 1) return true;
        Array.Sort(arr);
        List<int> occurs = new List<int>();
        int occur = 1;
        for(int i = 1; i < n; i++){
            if(arr[i - 1] == arr[i])
                occur++;
            else
            {
                occurs.Add(occur);
                if(i == n-1)
                    occurs.Add(1);
                occur = 1;
            }
        }
        if(occur > 1) occurs.Add(occur);

        return occurs.Distinct().Count() == occurs.Count();
    }
}