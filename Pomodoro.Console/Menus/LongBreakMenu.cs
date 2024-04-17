using Pomodoro.Console.Classes;
using Pomodoro.Library;

namespace Pomodoro.Console.Menus;

public static class LongBreakMenu
{
    public static void Open()
    {
        System.Console.Clear();
        System.Console.WriteLine("STARTING LONG BREAK TIMER");
        InfoWriter.Info("15 Minute Timer has started");

        var timer = new ConsoleTimer(15);
        timer.Run();

        InfoWriter.Success($"{Environment.NewLine}Time has Elapsed");
        System.Console.WriteLine("Press enter to return to main menu");
        System.Console.ReadLine();
    }
}
