public class Solution {
    private bool Check(char[][] board, int n, int m, int row, int end)
    {
        for (int i = 0; i < n; i++)
{
    var memo = new HashSet<char>();
    for (int j = 0; j < m; j++)
    {
        if (memo.Contains(board[i][j]))
        {
            return false;
        }
        else if (board[i][j] is not '.')
        {
            memo.Add(board[i][j]);
        }
    }
    memo.Clear();
}

for (int i = 0; i < n; i++)
{
    var memo = new HashSet<char>();
    for (int j = 0; j < m; j++)
    {
        if (memo.Contains(board[j][i]))
        {
            return false;
        }
        else if (board[j][i] is not '.')
        {
            memo.Add(board[j][i]);
        }
    }
    memo.Clear();
}

return true;
    }

    private bool CheckSmall(char[][] board, int n, int m, int start, int end)
    {
        var memo = new HashSet<char>();
        for (int i = start; i < n; i++)
        {
            for (int j = end; j < m; j++)
            {
                var a = board[i][j];
                if(memo.Contains(a))
                {
                    return false;
                }
                else if(a is not '.')
                {
                    memo.Add(a);
                }
            }
        }

        return true;
    }

    public bool IsValidSudoku(char[][] board) {
        int n = 9;
        int m = 9;
        var is9X9 = this.Check(board, n, m, 0 , 0);
        if(!is9X9) {
            return false;
        };

        for(int i = 0; i<n;i+=3)
        {
            for(int j = i; j < m;j+=3)
            {
                var is3X3 = this.CheckSmall(board, i+3, j+3, i, j);
                if(!is3X3) {
                    return false;
                };
            }
        }

        return true;
    }
}
