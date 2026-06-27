public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        if(nums.Count() == 0) return new List<int>().ToArray();
        var result = new List<int>();
        for(int i = 0; i< nums.Count();i++)
        {
            int m = 1;
            for(int j = 0; j < nums.Count();j++)
            {
                if(i != j)
                {
                    m *= nums[j];
                }
            }
            result.Add(m);
        }

        return result.ToArray();
    }
}
