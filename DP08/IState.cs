

namespace DP08;

public interface IState
{
    void DisplayState();
    void TurnOn(Oven oven, int temperature);
    void TurnOff(Oven oven);
    void SetTimer(Oven oven, int minutes);
}
