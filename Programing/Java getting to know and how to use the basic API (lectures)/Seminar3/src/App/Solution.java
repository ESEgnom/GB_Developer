package App;

public class Solution {
    public static int countPaths(int m, int n, int entryX, int entryY) {
        int[][] field = new int[m][n];
        for (int i = entryX; i < m; i++) {
            field[i][entryY] = 1;
        }
        for (int j = entryY; j < n; j++) {
            field[entryX][j] = 1;
        }
        for (int i = entryX + 1; i < m; i++) {
            for (int j = entryY + 1; j < n; j++) {
                field[i][j] = field[i - 1][j] + field[i][j - 1];
            }
        }
        return field[m - 1][n - 1];
    }
}
