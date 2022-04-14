namespace XclParser.Lexer
{
    /// <summary>
    /// Types of Lexer tokens
    /// </summary>
    internal enum TokenType
    {
        Identifier,
        Operator,
        Space,
        StringLiteral,
        Comment,
        NewLine,
    }
}
