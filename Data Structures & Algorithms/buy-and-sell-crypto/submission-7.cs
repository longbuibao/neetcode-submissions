public class Solution {
    public int MaxProfit(int[] prices) {
        var currentMin = prices[0];
        var max = 0;

        for(int i = 1 ; i< prices.Count(); i++)
        {
            currentMin = Math.Min(currentMin, prices[i]);
            max = Math.Max(max, prices[i] - currentMin);
        }

        return max;
    }
}
