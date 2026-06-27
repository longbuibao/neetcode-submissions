public class Solution
{
    public string Encode(IList<string> strs)
    {
        var result = new List<string>();

        foreach (string str in strs)
        {
            if (string.IsNullOrEmpty(str))
            {
                result.Add("E"); // special marker for empty string
                continue;
            }

            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                sb.Append(((int)c).ToString());
                sb.Append(';');
            }

            result.Add(sb.ToString());
        }

        return string.Join('#', result);
    }

    public List<string> Decode(string s)
    {
        if (string.IsNullOrEmpty(s))
            return new List<string>(); // if encoded string is empty, return empty list

        var strs = s.Split('#');
        var result = new List<string>();

        foreach (string str in strs)
        {
            if (str == "E")
            {
                result.Add(""); // handle empty string marker
                continue;
            }

            StringBuilder sb = new StringBuilder();
            var parts = str.Split(';');

            foreach (string part in parts)
            {
                if (!string.IsNullOrEmpty(part))
                {
                    int i = int.Parse(part);
                    sb.Append((char)i);
                }
            }

            result.Add(sb.ToString());
        }

        return result;
    }
}