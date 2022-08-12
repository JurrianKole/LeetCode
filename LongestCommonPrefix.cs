public class Solution 
{
    public string LongestCommonPrefix(string[] strs) 
    {
        if (strs.Length == 1)
        {
            return strs[0];
        }
        
        var maximumPrefixLength = strs[0].Length;
        
        for (var i = 1; i < strs.Length; i++)
        {
            maximumPrefixLength = strs[i].Length < maximumPrefixLength ? strs[i].Length : maximumPrefixLength;
        }
        
        var longestPrefix = "";
        var isValid = true;
        
        for (var i = 0; i < maximumPrefixLength; i++)
        {
            var currentCharacter = strs[0][i];
            
            for (var j = 1; j < strs.Length; j++)
            {
                if (strs[j][i] != currentCharacter)
                {
                    isValid = false;
                    break;
                }
            }
            
            if (!isValid)
            {
                break;
            }
            
            longestPrefix += currentCharacter;
        }
        
        return longestPrefix;
    }
}
