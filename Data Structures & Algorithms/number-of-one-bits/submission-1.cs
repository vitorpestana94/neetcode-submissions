public class Solution {
    public int HammingWeight(uint n)
    {
        string binaryRepresentation = Convert.ToString(n, 2);
        int count = 0;

        foreach (char element in binaryRepresentation)
        {
            if(element == '1')
                count++;
        }


        return count;
    }
}
