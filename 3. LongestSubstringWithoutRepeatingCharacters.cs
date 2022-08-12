public int LengthOfLongestSubstring(string s) 
{
    if (s.Length <= 1)
    {
        return s.Length;
    }

    var longestSubstringLength = 0;

    for (var i = 0; i < s.Length; i++)
    {
        var set = new HashSet<string>();

        set.Add(s[i].ToString());

        for (var j = i + 1; j < s.Length; j++)
        {
            if (!set.Add(s[j].ToString()))
            {                    
                break;
            }
        }

        longestSubstringLength = set.Count > longestSubstringLength ? set.Count : longestSubstringLength;
    }

    return longestSubstringLength;
}
