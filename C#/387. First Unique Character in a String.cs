// 387. First Unique Character in a String
public class Solution {
    public int FirstUniqChar(string s) {
        int[] count = new int[26];
        for (int i = 0; i < s.Length; i++) {
            count[s[i] - 'a']++;
        }
        for (int i = 0; i < s.Length; i++) {
            if (count[s[i] - 'a'] == 1) {
                return i;
            }
        }
        return -1;
    }
}