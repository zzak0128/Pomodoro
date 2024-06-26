﻿
using Pomodoro.Console.Classes;
using Pomodoro.Library.Enums;

namespace Pomodoro.Console.Menus;

public static class MainMenu
{
    public static AppStatus Open()
    {
        List<string> menuOptions = [
                "Start Pomodoro Timer",
        "Start Short Break",
        "Start Long Break",
        "Exit"
        ];

        Menu mainMenu = new("Pomodoro", menuOptions);
        int selectedOption = mainMenu.Start();

        switch (selectedOption)
        {
            case 0:
                System.Console.WriteLine("Starting Timer");
                TimerMenu.Open();

                return AppStatus.Running;
            case 1:
                System.Console.WriteLine("Starting short break");
                ShortBreakMenu.Open();

                return AppStatus.Running;
            case 2:
                System.Console.WriteLine("Starting long break");
                LongBreakMenu.Open();
                
                return AppStatus.Running;
            case 3:
                System.Console.Clear();
                return AppStatus.Exiting;
            default:
                System.Console.WriteLine("Unexpected option, closing");
                Environment.Exit(0);
                return AppStatus.Exiting;
        }
    }

}
