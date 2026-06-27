public class Solution {
    public bool hasDuplicate(int[] nums) {
var memo = new HashSet<int>();
for (var i = 0; i < nums.Count(); i++)
{
    if (memo.Contains(nums[i]))
    {
        return true;
    }
    else
    {
        memo.Add(nums[i]);
    }
}
return false;
    }
}
