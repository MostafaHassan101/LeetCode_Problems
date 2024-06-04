// 2486. Append Characters to String to Make Subsequence

public class Solution {
    public int AppendCharacters(string s, string t) {
        int sIndex = 0, tIndex = 0;
        int sLength = s.Length, tLength = t.Length;
        
        while (sIndex < sLength && tIndex < tLength) {
            if (s[sIndex] == t[tIndex]) {
                tIndex++;
            }
            sIndex++;
        }
        
        return tLength - tIndex;
        
    }
}