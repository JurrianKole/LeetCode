public int[] TwoSum(int[] nums, int target) 
{
    if (nums == null || nums.Length <= 1)
    {
        return new int[0];
    }

    var map = new Dictionary<int, int>();

    for (var index = 0; index < nums.Length; index++)
    {
        if (map.ContainsKey(target - nums[index]))
        {
            return new int[2] { map[target - nums[index]], index };
        }
        else
        {
            map.TryAdd(nums[index], index);
        }
    }

    return new int[0];
}
