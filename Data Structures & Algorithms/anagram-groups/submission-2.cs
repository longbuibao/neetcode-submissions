public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> result =
    strs.GroupBy(w => new string(w.OrderBy(c => c).ToArray()))
         .Select(g => g.ToList())
         .ToList();
// [["eat","tea","ate"], ["tan","nat"], ["bat"]]

    return result;
        
    }
}
