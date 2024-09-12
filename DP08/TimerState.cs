using static System.Console;
namespace DP08;

public class TimerState : IState
{
    private int temperature;
    private int minutes;

    public TimerState(int temperature, int minutes)
    {
        this.temperature = temperature;
        this.minutes = minutes;
    }

    public void DisplayState()
    {
        WriteLine($"Духовка включена на {minutes} минут, температура {temperature}°C.");
    }

    public void TurnOn(Oven oven, int temperature)
    {
        WriteLine("Духовка уже включена.");
    }

    public void TurnOff(Oven oven)
    {
        oven.CurrentState = new OffState();
        WriteLine("Духовка выключилась по истечении таймера.");
    }

    public void SetTimer(Oven oven, int minutes)
    {
        WriteLine("Таймер уже установлен.");
    }
}
