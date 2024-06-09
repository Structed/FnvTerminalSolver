namespace FnvTerminalSolver.Web;

public record WordMatch(string WordA, string WordB, char[] CommonCharacters)
{
    public string WordA { get; set; } = WordA;
    public string WordB { get; set; } = WordB;
    public char[] CommonCharacters { get; set; } = CommonCharacters;
}