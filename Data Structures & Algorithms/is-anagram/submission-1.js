class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */

    createObject = (s) => {
				return s.split('').reduce((mem, current) => {
            const value = mem[current]
            if(value !== undefined) {
                mem[current] = value + 1
            }
            else {
                mem[current] = 1
            }

            return mem
        }, {})
		}

    isAnagram(s, t) {
        const _s = this.createObject(s)
				const _t = this.createObject(t)

                if(Object.keys(_s).length !== Object.keys(_t).length)
					return false

        for (const key in _s) {
					if (Object.prototype.hasOwnProperty.call(_s, key)) {
						const element = _s[key];
						if(_t[key] !== element)
							return false
					}
				}

				return true
    }
}
