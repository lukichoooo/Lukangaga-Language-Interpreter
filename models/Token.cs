namespace simple_interpreter.models;

interface IToken
{
    public string Value { get; set; }
}

enum TokenType
{
    Number,
    Operator,
    Unknown,
}
