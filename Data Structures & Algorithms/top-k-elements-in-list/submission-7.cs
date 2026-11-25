public class Solution {
  public int[] TopKFrequent(int[] nums, int k)
 {
     Dictionary<int, int> freqNumbrs = [];

     foreach (int numbr in nums)
     {
         if (!freqNumbrs.TryAdd(numbr, 1))
             freqNumbrs[numbr] += 1;
     }

     
        
            return freqNumbrs.OrderByDescending(x => x.Value).Select(x => x.Key).Where((x, index) => index + 1 <= k).ToArray();
 }
}
