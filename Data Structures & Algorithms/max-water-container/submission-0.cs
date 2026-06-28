public class Solution {
    public int MaxArea(int[] heights) {
        var max = 0;
        for(int i = 0; i< heights.Length; i++)
        {
            for(int j = i + 1; j < heights.Length;j++)
            {
                var area = Math.Min(heights[i], heights[j]) * (j - i);
                max = Math.Max(area, max);
            }
        }

        return max;
    }
}
