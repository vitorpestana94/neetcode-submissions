public class Solution {
    public int[] PlusOne(int[] digits)
 {
     for (int i = digits.Length - 1; i >= 0; i--)
     {
         if (digits[i] < 9)
         {
             digits[i]++;

             break;
         }
         else
             digits[i] = 0;
     }

     if (digits[0] == 0)
     {
        digits = digits.Append(0).ToArray();
        digits[0] = 1;
     }

     return digits;
 }
}
