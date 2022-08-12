public class Solution {
    private static readonly Dictionary<string, int> Translation = new Dictionary<string, int>
    {
        { "I", 1 },
        { "IV", 4 },
        { "V", 5 },
        { "IX", 9 },
        { "X", 10 },
        { "XL", 40 },
        { "L", 50 },
        { "XC", 90 },
        { "C", 100 },
        { "CD", 400 },
        { "D", 500 },
        { "CM", 900 },
        { "M", 1000 }
    };
    
    public int RomanToInt(string s) {
        var sum = 0;
        
        for (var i = 0; i < s.Length; i++) 
        {
            if (i + 1 < s.Length)
            {
                if (Translation.TryGetValue(s[i].ToString() + s[i + 1].ToString(), out var addition))
                {
                    sum += addition;
                    i++;
                    continue;
                }
            }
            
            sum += Translation[s[i].ToString()];
        }
        
        return sum;
    }
}
