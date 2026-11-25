public class Solution {
    public int[] PlusOne(int[] digits)
{
    string number = "";

    foreach (int digit in digits)
    {
        number += digit;
    }

    string finalNumber = (long.Parse(number) + 1).ToString();

    int[] result = new int[finalNumber.Length];

    for (int i = 0; i < finalNumber.Length; i++)
    {
        result[i] = int.Parse(finalNumber[i].ToString());
    }

    return result;
}
}
