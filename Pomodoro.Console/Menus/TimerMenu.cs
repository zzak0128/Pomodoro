
namespace Pomodoro.Console.Menus;


public class TimerMenu
{
    public TimeSpan ElapsedTime
    {
        get { return DateTime.Now - StartTime; }
    }


    public TimeSpan Duration { get; set; }

    public DateTime StartTime { get; set; }

    public TimerMenu(TimeSpan duration)
    {
        Duration = duration;
    }

    public void StartTimer()
    {
        System.Console.Clear();
        System.Console.Write("POMODORO TIMER");

        StartTime = DateTime.Now;
        while (ElapsedTime.Seconds != 5)
        {
            System.Console.SetCursorPosition(0, 1);
            System.Console.Write(ElapsedTime);
        }

        System.Console.WriteLine($"{Environment.NewLine}Time has Elapsed");

        SoundAlarm();
        System.Console.ReadLine();
    }

    private void SoundAlarm()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                System.Console.Beep();
                Thread.Sleep(500);
            }
            System.Console.Beep();
            Thread.Sleep(1500);
        }
    }
}
