namespace Bracket_Checker_Example_Public;

public static class BracketChecker
{
    public static bool Check(string input)
    {
        Stack<char> open = new Stack<char>();
        foreach (char c in input)
        {
            switch (c)
            {
                case '(':
                    open.Push(c);
                    break;
                case ')':
                    if (open.Count == 0) return false;
                    open.Pop();
                    break;
            }
        }
        return open.Count == 0;
    }
}