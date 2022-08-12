public class Solution 
{
    public string LongestPalindrome(string s) 
    {
        if (s.Length == 1)
        {
            return s;
        }
        
        var ans = "";
        
        for (var i = 0; i < s.Length; i++)
        {
            var candidate = s[i].ToString();
            
            for (var j = i + 1; j < s.Length; j++)
            {
                candidate += s[j].ToString();
                
                if (IsPalindrome(candidate))
                {
                    ans = candidate.Length > ans.Length ? candidate : ans;
                }
            }
        }
        
        ans = ans == "" ? s[0].ToString() : ans;
        
        return ans;
    }
    
    private static bool IsPalindrome(string input)
    {
        if (input.Length == 1)
        {
            return true;
        }

        for (var i = 0; i <= input.Length / 2 - 1; i++)
        {
            if (input[i] != input[input.Length - 1 - i])
            {
                return false;
            }
        }
        
        return true;
    }
}
