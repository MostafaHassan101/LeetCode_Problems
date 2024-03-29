// 1758. Minimum Changes To Make Alternating Binary String

public class Solution {
    public int MinOperations(string s) {
        int count1 = 0;
        int count2 = 0;
        for(int i = 0; i < s.Length; i++){
            if(i % 2 == 0){
                if(s[i] == '0'){
                    count1++;
                }
                else{
                    count2++;
                }
            }
            else{
                if(s[i] == '1'){
                    count1++;
                }
                else{
                    count2++;
                }
            }
        }
        return Math.Min(count1, count2);
    }
}
