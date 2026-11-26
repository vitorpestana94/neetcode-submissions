public class Solution {
      public int MaxProfit(int[] prices)
  {
      int minPrice = prices[0];
      int profit = 0;

      for (int i = 0; i < prices.Length; i++)
      {
          if (prices[i] < minPrice)
              minPrice = prices[i];

          if(i != prices.Length - 1)
          {
              int currentProfit = prices[i + 1] - minPrice;

              if(currentProfit > profit)
                  profit = currentProfit;
          }
      }

      return profit;
  }
}
