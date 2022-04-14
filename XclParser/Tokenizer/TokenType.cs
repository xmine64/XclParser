namespace XclParser.Tokenizer
{
    /// <summary>
    /// Types of Tokenizer tokens
    /// </summary>
    internal enum TokenType
    {
        TypeName,
        ParameterStart,
        Value,
        SectionStart,
        SectionEnd,
        FieldName,
        SetOperator,
        Meaningless,
    }
}
