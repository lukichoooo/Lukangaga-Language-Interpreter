namespace simple_interpreter.service;

interface ILineParser
{
    bool TryParse(string line);
    void Parse(string line);
}

public class LineParser : ILineParser
{
    public bool TryParse(string line)
    {
        return false;
    }

    public void Parse(string line) { }
}
