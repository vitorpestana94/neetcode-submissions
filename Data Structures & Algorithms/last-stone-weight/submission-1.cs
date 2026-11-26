public class Solution {
      public int LastStoneWeight(int[] stones)
 {
     PriorityQueue<int, int> queue = new(Comparer<int>.Create((x, y) => y.CompareTo(x)));

     for (int i = 0; i < stones.Length; i++)
     {
         queue.Enqueue(stones[i], stones[i]);
     }

     while (queue.Count > 1)
     {
         int highestValue = queue.Dequeue();
         int secondHighestValue = queue.Dequeue();

         if (highestValue == secondHighestValue)
             continue;

         if (highestValue < secondHighestValue)
         {
             int result = secondHighestValue - highestValue;

             queue.Enqueue(result, result);
         }
         else
         {
             int result = highestValue - secondHighestValue;

             queue.Enqueue(result, result);

         }
     }

     if (!queue.TryDequeue(out int lastStone, out int _))
         return 0;

     return lastStone;
 }
}
