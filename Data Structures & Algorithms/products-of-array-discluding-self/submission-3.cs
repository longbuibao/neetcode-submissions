public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var prefix = new int[nums.Length];
        var postfix = new int[nums.Length];

        var a = 1;
        prefix[0] = 1;
        for(int i = 1; i < nums.Length; i++)
        {
            a *= nums[i - 1];
            prefix[i] = a;
        }
        //[1, 1, 2, 8]

        var b = 1;
        postfix[nums.Length - 1] = 1;
        for(int i = nums.Length - 2; i >= 0; i--)
        {
            b *= nums[i + 1];
            postfix[i] = b;
        }
        var result = new int[nums.Length];
        for(int i = 0;i<nums.Length;i++)
        {
            result[i] = (prefix[i] * postfix[i]);
        }

        return result;
    }
}
