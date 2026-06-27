class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs) {
        const sorted = strs.map(x => x.split('').sort().join(''))
			const memo = new Map()

			// [ 'act', 'opst', 'opst', 'act', 'opst', 'aht' ]

			for(let i =0;i<sorted.length;i++)
			{
				if(memo.has(sorted[i])) {
					const current = memo.get(sorted[i])
					current.push(strs[i])
					memo.set(sorted[i], current)
				}
				else memo.set(sorted[i], [strs[i]])
			}

			return Array.from(memo.values())
    }
}
