ConsoleColor defaultForegroundColor = Console.ForegroundColor;
Console.WriteLine();
Console.WriteLine("Enter an expression to test for matching brackets (or \"q\" to quit): ");

while (true)
{
    string input = Console.ReadLine() ?? string.Empty;
    if (input == "q")
    {
        break;
    }
    bool hasMatchingBrackets = ExpressionEvalHelper.CheckHasMatchingBrackets(input);
    Console.ForegroundColor = hasMatchingBrackets ? ConsoleColor.Green : ConsoleColor.Red;
    Console.WriteLine();
    Console.Write($"The expression {(hasMatchingBrackets ? "has" : "does not have")} matching brackets. ");
    Console.ForegroundColor = defaultForegroundColor;
    Console.Write("Enter another expression (or \"q\" to quit):");
    Console.WriteLine();
}