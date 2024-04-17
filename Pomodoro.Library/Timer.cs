namespace Pomodoro.Library;

public abstract class Timer(double duration)
{
    public double Duration { get; private set; } = duration;

    public DateTime StartTime { get; set; }

    public TimeSpan ElapsedTime
    {
        get { return DateTime.Now - StartTime; }
    }

    public abstract void Run();

    protected abstract void SoundAlarm();
}
