public class Solution 
{
    public int[] KWeakestRows(int[][] mat, int k) 
    {
        var dict = new Dictionary<int, int>();
        
        for (var i = 0; i < mat.Length; i++)
        {
            var count = 0;
            
            for (var j = 0; j < mat[i].Length; j++)
            {
                if (mat[i][j] == 0)
                {
                    break;
                }
                
                count++;
            }
            
            dict.Add(i, count);
        }
        
        return dict.OrderBy(d => d.Value).ThenBy(d => d.Key).Take(k).Select(d => d.Key).ToArray();
    }
}
