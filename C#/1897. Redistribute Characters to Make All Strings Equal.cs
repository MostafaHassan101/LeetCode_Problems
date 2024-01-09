// 1897. Redistribute Characters to Make All Strings Equal

public class Solution {
    public bool MakeEqual(string[] words) {
        int NrWords = words.Length;
        string word = String.Join("", words);
        int wordLen = word.Length;
        if(wordLen % NrWords != 0) return false;
        char[] charArray = word.ToCharArray();
        Array.Sort(charArray);

        word = new string(charArray);

        int eq = 1;
        for(int i = 1; i < wordLen; i++)
            if(word[i] == word[i-1])
                eq++;
            else
            {
                if(eq % NrWords != 0)
                    return false;
                else 
                    eq = 1;
            }
        return eq % NrWords == 0;
    }
}