class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number[]}
     */
    twoSum(nums, target) {
        const memo = new Map()
			for(let i = 0;i<nums.length;i++){
					const c = target - nums[i]
					if(memo.has(c))
					{
						return [memo.get(c), i]
					}
					else {
						memo.set(nums[i], i)
					}

			}
    }
}
