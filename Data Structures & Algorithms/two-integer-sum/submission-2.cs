public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = [];

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];

            if (dict.TryGetValue(diff, out int x))
                return [dict[diff], i];
            
            dict.Add(nums[i], i);
        }

        return [];
    }
}
