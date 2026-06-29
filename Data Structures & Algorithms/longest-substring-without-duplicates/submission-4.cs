public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var max = 1;

        if(string.IsNullOrEmpty(s))
        {
            return 0;
        }

        for(int i= 0;i<s.Length;i++)
        {
            var memo = new HashSet<char>();
            memo.Add(s[i]);
            for(int j = i + 1; j<s.Length;j++) {
                if(!memo.Contains(s[j]))
                {
                    memo.Add(s[j]);
                    max = Math.Max(max, memo.Count());
                }

                else {
                    break;
                }
            }
        }

        return max;
    }
}
