public class Solution 
{
    public int MaximumWealth(int[][] accounts) 
    {
        var answer = 0;
        
        for (var i = 0; i < accounts.Length; i++)
        {
            var answerCandidate = 0;
            
            for (var j = 0; j < accounts[i].Length; j++)
            {
                answerCandidate += accounts[i][j];
            }
            
            answer = answerCandidate > answer ? answerCandidate : answer;
        }
        
        return answer;
    }
}
