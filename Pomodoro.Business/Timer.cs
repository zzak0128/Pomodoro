namespace Pomodoro.Business;

public class Timer : IDisposable
{
    public double Duration { get; private set; }

    public DateTime StartTime { get; set; }

    public TimeSpan ElapsedTime
    {
        get { return DateTime.Now - StartTime; }
    }


    public Timer(double duration)
    {
        Duration = duration;
    }

    public async Task Start()
    {
        StartTime = DateTime.Now;

        var cursorPosition = Console.GetCursorPosition();
        while (ElapsedTime.TotalSeconds < Duration)
        {
            Console.SetCursorPosition(cursorPosition.Left, cursorPosition.Top);
            Console.Write(ElapsedTime.ToString(@"mm\:ss"));
        }

        SoundAlarm();
    }

    private static void SoundAlarm()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Beep();
                Thread.Sleep(500);
            }
            Console.Beep();
            Thread.Sleep(1500);
        }
    }

    public void Dispose()
    {
    }
}
