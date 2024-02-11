// 1463. Cherry Pickup II
public class Solution {
    public int CherryPickup(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;
        int[,,] dp = new int[n, m, m];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                for (int k = 0; k < m; k++) {
                    dp[i, j, k] = -1;
                }
            }
        }
        return Dfs(grid, dp, 0, 0, m - 1);
    }
    private int Dfs(int[][] grid, int[,,] dp, int row, int col1, int col2) {
        if (row == grid.Length) {
            return 0;
        }
        if (dp[row, col1, col2] != -1) {
            return dp[row, col1, col2];
        }
        int res = 0;
        for (int i = -1; i <= 1; i++) {
            for (int j = -1; j <= 1; j++) {
                int newCol1 = col1 + i;
                int newCol2 = col2 + j;
                if (newCol1 >= 0 && newCol1 < grid[0].Length && newCol2 >= 0 && newCol2 < grid[0].Length) {
                    res = Math.Max(res, Dfs(grid, dp, row + 1, newCol1, newCol2));
                }
            }
        }
        int cherries = col1 == col2 ? grid[row][col1] : grid[row][col1] + grid[row][col2];
        return dp[row, col1, col2] = res + cherries;
    }
}
