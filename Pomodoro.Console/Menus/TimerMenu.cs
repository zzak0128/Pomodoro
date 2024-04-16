
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

    public async Task Open()
    {
        System.Console.Clear();
        System.Console.WriteLine("POMODORO TIMER");

        var timer = new Pomodoro.Business.Timer(3);
        await timer.Start();

        System.Console.WriteLine($"{Environment.NewLine}Time has Elapsed");

        System.Console.ReadLine();
    }
}
