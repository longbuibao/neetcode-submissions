public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
    
    HashSet<int> numSet = new HashSet<int>(nums);
    int longestStreak = 0;
    
    foreach (int num in numSet) 
    {
        // Only start counting if this is the beginning of a sequence
        // (i.e., num-1 is not in the set)
        if (!numSet.Contains(num - 1)) 
        {
            int currentNum = num;
            int currentStreak = 1;
            
            // Count consecutive numbers
            while (numSet.Contains(currentNum + 1)) 
            {
                currentNum++;
                currentStreak++;
            }
            
            longestStreak = Math.Max(longestStreak, currentStreak);
        }
    }
    
    return longestStreak;
    }
}
