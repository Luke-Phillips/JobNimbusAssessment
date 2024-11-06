public static class ExpressionEvalHelper
{
    public static bool CheckHasMatchingBrackets(string expression)
    {
        // Represents the difference between the number of left brackets and the number of right brackets so far.
        // A negative difference is an automatic fail to match
        int bracketDifference = 0;

        foreach (char c in expression)
        {
            // Increment or decrement bracket difference, ignore non-bracket characters,
            if (c == '<')
            {
                bracketDifference++;
            }
            else if (c == '>')
            {
                bracketDifference--;
            }
            
            // If the number of right brackets ever exceeds the number of left brackets (as we move left to right),
            // we know the expression cannot have matching brackets and can return early
            if (bracketDifference < 0)
            {
                return false;
            }
        }

        // If there are an unequal number of left and right brackets,
        // we know the expression cannot have matching brackets
        if (bracketDifference != 0)
        {
            return false;
        }

        // In all other situation, we know the expression has matching brackets
        return true;
    }
}