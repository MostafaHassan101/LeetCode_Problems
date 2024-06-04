// 409. Longest Palindrome

public class Solution {
    public int LongestPalindrome(string s) {
        var dict = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict[c] = 1;
        }
        
        var res = 0;
        var hasOdd = false;
        foreach (var v in dict.Values)
        {
            if (v % 2 == 0)
                res += v;
            else
            {
                res += v - 1;
                hasOdd = true;
            }
        }
        
        return hasOdd ? res + 1 : res;
    }
}

// Other solution with HashSet instead of Dictionary

public class Solution {
    public int LongestPalindrome(string s) {
        var set = new HashSet<char>();
        var maxLength = 0;

        foreach (var c in s)
        {
            if (set.Contains(c))
            {
                set.Remove(c);
                maxLength += 2;
            }
            else
                set.Add(c);
        }

        return set.Count > 0 ? maxLength + 1 : maxLength;
    }
}