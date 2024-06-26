﻿using Pomodoro.Console.Classes;
using Pomodoro.Library;

namespace Pomodoro.Console.Menus;


public static class TimerMenu
{
    public static void Open()
    {
        System.Console.Clear();
        System.Console.WriteLine("STARTING POMODORO TIMER");
        InfoWriter.Info("25 Minute Timer has started");

        var timer = new ConsoleTimer(25);
        timer.Run();

        InfoWriter.Success($"{Environment.NewLine}Time has Elapsed");
        System.Console.WriteLine("Press enter to return to main menu");
        System.Console.ReadLine();
    }
}
