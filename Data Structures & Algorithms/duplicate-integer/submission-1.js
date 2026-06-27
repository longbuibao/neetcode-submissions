class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
        const dict = new Set(nums)
        if(dict.size === nums.length)
        {return false}
        return true;
    }
}
