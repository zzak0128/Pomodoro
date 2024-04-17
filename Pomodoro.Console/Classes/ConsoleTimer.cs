namespace Pomodoro.Console.Classes;

public class ConsoleTimer : Library.Timer
{

    public ConsoleTimer(double duration) : base(duration)
    {

    }

    public override void Run()
    {
        StartTime = DateTime.Now;

        System.Console.WriteLine("Press ESC to cancel...");
        
        var cursorPosition = System.Console.GetCursorPosition();

        while (ElapsedTime.TotalMinutes < Duration)
        {
                System.Console.SetCursorPosition(cursorPosition.Left, cursorPosition.Top);
                System.Console.Write(ElapsedTime.ToString(@"mm\:ss"));

            if (System.Console.KeyAvailable && System.Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                return;
            }
        }

        SoundAlarm();
    }


    protected override void SoundAlarm()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                System.Console.Beep();
                Thread.Sleep(500);
                System.Console.WriteLine("Timer Complete");
            }
            System.Console.Beep();
            Thread.Sleep(1500);
            System.Console.WriteLine("Timer Complete");
        }
    }
}
