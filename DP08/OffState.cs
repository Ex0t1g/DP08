using static System.Console;

namespace DP08;

public class OffState : IState
{
    public void DisplayState()
    {
        WriteLine("Духовка выключена.");
    }

    public void TurnOn(Oven oven, int temperature)
    {
        oven.CurrentState = new OnState(temperature);
        WriteLine($"Духовка включена, установлена температура {temperature}°C.");
    }

    public void TurnOff(Oven oven)
    {
        WriteLine("Духовка уже выключена.");
    }

    public void SetTimer(Oven oven, int minutes)
    {
        WriteLine("Духовка выключена, таймер не может быть установлен.");
    }
}
