public class Solution {
     public int MissingNumber(int[] nums)
 {
     HashSet<int> allNumbers = [..nums];
     int missing = 0;

     for (int i = 0; i < nums.Length + 1; i++)
     {
         if (!allNumbers.TryGetValue(i, out _))
             missing = i;
     }

     return missing;
 }
}
