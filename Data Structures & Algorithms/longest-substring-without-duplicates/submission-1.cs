public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var visited = new HashSet<char>();
        int left = 0;
        int right = 0;
        int max = 0;

        while(right < s.Length)
        {
            if(visited.Contains(s[right]))
            {
                visited.Remove(s[left]);
                left++;
            }

            else {
                visited.Add(s[right]);
                right++;
                max = Math.Max(max, (right - left));
            }
        }

        return max;
    }
}
