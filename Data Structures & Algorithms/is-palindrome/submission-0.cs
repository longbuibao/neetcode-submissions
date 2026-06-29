public class Solution {
    public bool IsPalindrome(string s) {
        Regex rgx = new Regex("[^a-zA-Z0-9 -]");
        var a = rgx.Replace(s, "").Replace(" ", "").ToLowerInvariant();
        int left = 0;
        int right = a.Length - 1;

        while (left < right)
        {
            if (a[left] != a[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
