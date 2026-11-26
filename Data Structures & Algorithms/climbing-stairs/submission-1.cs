public class Solution {
    public int ClimbStairs(int n)
    {
     if (n <= 1) return n;

 int actualElement = 0;
 int nextElement = 1;
 int sum = 0;

 for (int i = 2; i <= n + 1; i++)
 {
     sum = actualElement + nextElement;
     actualElement = nextElement;
     nextElement = sum;
 }

 return sum;
    }
}
