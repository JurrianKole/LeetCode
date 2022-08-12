public class Solution 
{
    public int MaxArea(int[] height) 
    {
        var maximumArea = 0;
        
        var left = 0;
        var right = height.Length - 1;
        
        while (left < right)
        {
            var minHeight = height[left] <= height[right]
                ? height[left]
                : height[right];
            
            var area = minHeight * (right - left);
            
            if (area > maximumArea)
            {
                maximumArea = area;
            }
            
            if (height[left] <= height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
                
        return maximumArea;
    }
}
