public class ExpressionEvaluator_HasMatchingBrackets
{
    // Assessment-required test
    [Fact]
    public void HasMatchingBrackets_NoBracketsOrCharacters___ReturnsTrue()
    {
        string expression = "";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.True(actual);
    }
    
    [Fact]
    public void HasMatchingBrackets__NoBracketsWithCharacters__ReturnsTrue()
    {
        string expression = "j0bn1mbu5";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.True(actual);
    }

    // Assessment-required test
    [Fact]
    public void HasMatchingBrackets_OnePairMatchingBrackets_ReturnsTrue()
    {
        string expression = "<>";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.True(actual);
    }

    // Assessment-required test
    [Fact]
    public void HasMatchingBrackets_OnePairMatchingBracketsWithCharacters_ReturnsTrue()
    {
        string expression = "<abc...xyz>";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.True(actual);
    }

    [Fact]
    public void HasMatchingBrackets_SiblingMatchingBrackets_ReturnsTrue()
    {
        string expression = "<><>";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.True(actual);
    }

    [Fact]
    public void HasMatchingBrackets_NestedMatchingBrackets_ReturnsTrue()
    {
        string expression = "<<>>";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.True(actual);
    }
    
    [Fact]
    public void HasMatchingBrackets_ComplexMatchingBrackets_ReturnsTrue()
    {
        string expression = "<<<><<><>><>><<<>><>>>";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.True(actual);
    }
    
    [Fact]
    public void HasMatchingBrackets_ComplexMatchingBracketsWithCharacters_ReturnsTrue()
    {
        string expression = "<1<*<job><<nimbus><is>><super>><-<-<rad>->-<!!!>!>!>";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.True(actual);
    }

    // Assessment-required test
    [Fact]
    public void HasMatchingBrackets_EqualNumberBracketsMismatch1_ReturnsFalse()
    {
        string expression = "><";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.False(actual);
    }
    
    [Fact]
    public void HasMatchingBrackets_EqualNumberBracketsMismatch2_ReturnsFalse()
    {
        string expression = "<>><";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.False(actual);
    }
    
    [Fact]
    public void HasMatchingBrackets_EqualNumberBracketsMismatch3_ReturnsFalse()
    {
        string expression = "<<>>><<>";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.False(actual);
    }

    [Fact]
    public void HasMatchingBrackets_MissingRightBracketSimple_ReturnsFalse()
    {
        string expression = "<";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.False(actual);
    }

    [Fact]
    public void HasMatchingBrackets_MissingRightBracketWithCharacter_ReturnsFalse()
    {
        string expression = "<}";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.False(actual);
    }

    // Assessment-required test
    [Fact]
    public void HasMatchingBrackets_MissingRightBracket_ReturnsFalse()
    {
        string expression = "<<>";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.False(actual);
    }

    [Fact]
    public void HasMatchingBrackets_MissingRightBracketComplex_ReturnsFalse()
    {
        string expression = "<<<><>><>";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.False(actual);
    }

    [Fact]
    public void HasMatchingBrackets_MissingLeftBracketSimple_ReturnsFalse()
    {
        string expression = ">";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.False(actual);
    }
    
    [Fact]
    public void HasMatchingBrackets_MissingLeftBracketWithCharacter_ReturnsFalse()
    {
        string expression = "(>";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.False(actual);
    }

    [Fact]
    public void HasMatchingBrackets_MissingLeftBracket_ReturnsFalse()
    {
        string expression = "<>>";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.False(actual);
    }

    [Fact]
    public void HasMatchingBrackets_MissingLeftBracketComplexWithCharacters_ReturnsFalse()
    {
        string expression = "*<<<a>><<b><c>><<d>(e><f>>->";
        bool actual = ExpressionEvalHelper.CheckHasMatchingBrackets(expression);

        Assert.False(actual);
    }
}