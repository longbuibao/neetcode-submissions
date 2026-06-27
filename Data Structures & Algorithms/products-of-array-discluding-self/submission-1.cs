public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var a = new List<int>();
        for(int i = 0; i< nums.Length; i++)
        {
            var result = 1;
            for(int j = 0 ; j < nums.Length; j++)
            {
                if(i != j)
                {
                    result *= nums[j];
                }
            }

            a.Add(result);
        }

        return a.ToArray();
    }
}
