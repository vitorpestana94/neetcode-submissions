public class Solution {
     public bool hasDuplicate(int[] nums)
    {
        for (int x = 0; x < nums.Length; x++)    {
            for (int y = x + 1; y < nums.Length; y++)
            {
                if (nums[x] == nums[y])
                {
                    return true;
                }
            }
        }

        return false;
    }
}