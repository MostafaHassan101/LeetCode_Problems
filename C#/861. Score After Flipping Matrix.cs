// 861. Score After Flipping Matrix
public class Solution {
    public int MatrixScore(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        int res = m * (1 << (n - 1));
        for (int j = 1; j < n; j++) {
            int cur = 0;
            for (int i = 0; i < m; i++) {
                cur += grid[i][j] == grid[i][0] ? 1 : 0;
            }
            res += Math.Max(cur, m - cur) * (1 << (n - j - 1));
        }
        return res;
    }
    
}