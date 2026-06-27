public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var result = nums.Aggregate(new Dictionary<int, int>(), (acc, y) =>
            {
                if (!acc.ContainsKey(y))
                {
                    acc.TryAdd(y, 1);
                }
                else
                {
                    acc[y]++;
                }

                return acc;
            })
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
        return result;
    }
}
