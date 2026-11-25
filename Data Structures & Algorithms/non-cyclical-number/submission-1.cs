public class Solution {
     private int Calculate(string numberParts)
 {
     int result = 0;

     foreach (char nu in numberParts)
     {
         int number = int.Parse(nu.ToString());

         result +=  number * number;
     }

     return result;
 }

 public bool IsHappy(int n)
 {
     int result = Calculate(n.ToString());

     if(result == 1)
         return true;
     
     HashSet<int> results = [];

     while(result != 1)
     {
         if(!results.Add(result))
             return false;

         result = Calculate(result.ToString());
     }

     return true;
 }
}
