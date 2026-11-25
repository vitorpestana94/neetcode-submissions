public class Solution {
     public bool IsValid(string s)
{
    if(string.IsNullOrEmpty(s) || s.Length < 2) 
        return false;

    Dictionary<char, char> map = new()
    {
        { '[', ']' },
        { '(', ')' },
        { '{', '}' },
    };

    Stack<char> stack = new();

    foreach(char c in s)
    {
        if(map.TryGetValue(c, out char _))
        {
            stack.Push(c);
        }
        else
        {
            char closingParenthesis = c;

            if(stack.TryPop(out char lastOpeningParenthesis))
            {
                if(map.TryGetValue(lastOpeningParenthesis, out char correctClosingParenthesis))
                {
                    if(closingParenthesis != correctClosingParenthesis)
                        return false;
                }
            }
            else
            {
                return false;
            }
        }
    }

    if (stack.TryPeek(out char result))
        return false;

    return true;
}
}
