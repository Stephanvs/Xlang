namespace Xlang.CodeAnalysis
{
    public enum SyntaxKind
    {
        // Tokens
        EndOfFileToken,
        BadToken,

        NumberToken,
        WhitespaceToken,
        PlusToken,
        MinusToken,
        StarToken,
        SlashToken,
        OpenParenthesisToken,
        CloseParenthesisToken,


        LiteralExpression,
        BinaryExpression,
        ParenthesizedExpression
    }
}