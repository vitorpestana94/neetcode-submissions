public class Solution {
    public bool IsPalindrome(string s)
    {
        string words = new string(s.ToLower().Where(char.IsLetterOrDigit).ToArray());

        int left = 0;
        int right = words.Length - 1;

        while (left < right)
        {
            if (words[left] != words[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}
