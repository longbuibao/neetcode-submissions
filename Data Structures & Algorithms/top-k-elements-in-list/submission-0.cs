public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var result = new List<int>();
        var counter = new Dictionary<int, int>();

        for(int i = 0; i< nums.Count();i++)
        {
            if(!counter.ContainsKey(nums[i]))
            {
                counter[nums[i]] = 1;
            }
            else {
                counter[nums[i]]++;
            }
        }

        for(int i = 1; i<=k;i++)
        {
            var max = counter.MaxBy(x => x.Value);
            result.Add(max.Key);
            counter.Remove(max.Key);
        }

        return result.ToArray();
    }
}
