public class Solution {
     private int CountBitsOne(int number)
 {
     int count = 0;

     while (number != 0)
     {
         number &= number - 1;
         count++;
     }

     return count;
 }

 public int[] CountBits(int n)
 {
     int[] response = new int[n + 1];

     for (int i = 0; i < n + 1; i++)
     {
         response[i] = CountBitsOne(i);
     }

     return response;
 }
}
