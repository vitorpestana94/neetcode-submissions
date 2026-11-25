public class Solution {
    public bool hasDuplicate(int[] nums)
    {
        Dictionary<int, int>  numsDict = [];

        foreach (int num in nums)
        {
            if (numsDict.ContainsKey(num))
                return true;

            numsDict.Add(num, 0);
        }

        return false;
    }
}