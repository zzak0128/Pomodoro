namespace Pomodoro.Library;

public static class InfoWriter
{
    public static void Info(string message)
    {
        WriteMessage(message, ConsoleColor.Yellow);
    }

    public static void Warning(string message)
    {
        WriteMessage(message, ConsoleColor.Red);
    }

    public static void Success(string message)
    {
        WriteMessage(message, ConsoleColor.Green);
    }

    private static void WriteMessage(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}
