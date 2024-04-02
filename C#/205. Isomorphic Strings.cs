// 205. Isomorphic Strings

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length) return false;

        Dictionary<char,char> dict = new();
        for(int i = 0; i < s.Length; i++){
            if(dict.ContainsKey(s[i])){
                if(dict[s[i]] != t[i]) return false;
            }
            else{
                if(dict.ContainsValue(t[i])) return false;
                dict[s[i]] = t[i];
            }
        }
        return true;
    }
}