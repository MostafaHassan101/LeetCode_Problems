// 231. Power of Two
public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n == 0 || n < 0 ) return false;
        return Convert.ToDecimal(Math.Log(n, 2)) % 1 == 0;
    }
}