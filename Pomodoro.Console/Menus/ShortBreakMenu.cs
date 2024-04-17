using Pomodoro.Console.Classes;
using Pomodoro.Library;

namespace Pomodoro.Console.Menus;

public static class ShortBreakMenu
{
    public static void Open()
    {
        System.Console.Clear();
        System.Console.WriteLine("STARTING SHORT BREAK TIMER");
        InfoWriter.Info("5 Minute Timer has started");

        var timer = new ConsoleTimer(5);
        timer.Run();

        InfoWriter.Success($"{Environment.NewLine}Time has Elapsed");
        System.Console.WriteLine("Press enter to return to main menu");
        System.Console.ReadLine();
    }
}
