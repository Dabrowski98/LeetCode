namespace LeetCode
{
    class TwoSumClass
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> result = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.ContainsKey(target - nums[i])) return [i, result[target - nums[i]]];
                else result[nums[i]] = i;
            }
            return null;
        }
    }
}
