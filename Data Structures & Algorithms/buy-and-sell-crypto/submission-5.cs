public class Solution {
    public int MaxProfit(int[] prices) {
        int minSoFar = prices[0];
        int res = 0;

        
        for (int i = 1; i < prices.Length; i++) {
            
            // Update the minimum value seen so far 
            minSoFar = Math.Min(minSoFar, prices[i]);
            
            // Update result if we get more profit                
            res = Math.Max(res, prices[i] - minSoFar);
        }
        return res;
    }
}
