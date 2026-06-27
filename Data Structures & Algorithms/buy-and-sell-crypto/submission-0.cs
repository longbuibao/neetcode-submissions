public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0;
        int right = 1;
        int max = 0;

        while(right < prices.Count())
        {
            if(prices[left] > prices[right])
            {
                left++;
            }

            else {
                max = Math.Max(max, prices[right] - prices[left]);
                right++;
            }
        }

        return max;
    }
}
