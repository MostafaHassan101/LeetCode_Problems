// 2000. Reverse Prefix of Word
public class Solution {
    public string ReversePrefix(string word, char ch) {
        int eq = 0;
        for(int i = 0; i < word.Length; i++ ){
            if(word[i] == ch){
                eq = i;
                break;
            }
        }
        if (eq != 0)
        {
            Console.WriteLine(eq);
            char[] wordArray = word.ToCharArray();
            int j = eq;
            for (int i = 0; i < ((eq + 1) / 2); i++)
            {
                char temp = wordArray[i];
                wordArray[i] = wordArray[j];
                wordArray[j] = temp;
                j--;
            }
            word = new string(wordArray);
        }
        return word;
    }
}
// other solution
public class Solution {
    public string ReversePrefix(string word, char ch) {
        int index = word.IndexOf(ch);
        if (index == -1) return word;
        char[] arr = word.ToCharArray();
        int i = 0, j = index;
        while (i < j) {
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            i++;
            j--;
        }
        return new string(arr);
    }
}