public class Solution 
{
    public string IntToRoman(int num) 
    {
        var symbols = new Dictionary<string, int>
        {
            { "M", 1000 },
            { "CM", 900 },
            { "D", 500 },
            { "CD", 400 },
            { "C", 100 },
            { "XC", 90 },
            { "L", 50 },
            { "XL", 40 },
            { "X", 10 },
            { "IX", 9 },
            { "V", 5 },
            { "IV", 4 },
            { "I", 1 }
        };

        var result = "";

        foreach (var symbol in symbols)
        {
            var remainder = num % symbol.Value;

            if (remainder != num)
            {
                var amountOfCharacters = num / symbol.Value;
                result += string.Concat(Enumerable.Repeat(symbol.Key, amountOfCharacters));

                num %= symbol.Value;
            }
        }

        return result;
    }
}
