using System;
using System.Linq.Expressions;
using static System.Console;
namespace DP08;

public class OnState : IState
{
    private int temperature;

    public OnState(int temperature)
    {
        this.temperature = temperature;
    }

    public void DisplayState()
    {
        WriteLine($"Духовка включена, установлена температура {temperature}°C.");
    }

    public void TurnOn(Oven oven, int temperature)
    {
        WriteLine("Духовка уже включена.");
    }

    public void TurnOff(Oven oven)
    {
        oven.CurrentState = new OffState();
        WriteLine("Духовка выключена.");
    }

    public void SetTimer(Oven oven, int minutes)
    {
        oven.CurrentState = new TimerState(temperature, minutes);
        WriteLine($"Духовка включена на {minutes} минут, температура {temperature}°C.");
    }
}
