public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var prefix = new int[nums.Length];
        var postfix = new int[nums.Length];

        // 1, 2, 3, 4
        
        // 1, 1, 2, 6
        // 24, 12, 4, 1

        var pPrefix = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i is 0)
            {
                prefix[0] = 1;
                continue;
            }

            pPrefix *= nums[i - 1];
            prefix[i] = pPrefix;
        }
        
        var pPostfix = 1;
        var length = nums.Length;
        for (int i = length - 1; i >= 0; i--)
        {
            if (i == length - 1)
            {
                postfix[length - 1] = 1;
                continue;
            }

            pPostfix *= nums[i + 1];
            postfix[i] = pPostfix;
        }

        var result = new int[nums.Length];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = prefix[i] * postfix[i];
        }

        return result;
    }
}
