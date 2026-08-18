public class Solution {
    public int MaxProfit(int[] prices) {
        var min = prices[0];
        var max = -1;

        foreach(var x in prices)
        {
            min = Math.Min(min, x);

            max = Math.Max(max,x - min);
        }

        return max;

    }
}
