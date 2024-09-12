
namespace DP08;
public  class Oven
{
    public IState CurrentState { get; set; }

    public Oven()
    {
        CurrentState = new OffState();
    }

    public void TurnOn(int temperature)
    {
        CurrentState.TurnOn(this, temperature);
    }

    public void TurnOff()
    {
        CurrentState.TurnOff(this);
    }

    public void SetTimer(int minutes)
    {
        CurrentState.SetTimer(this, minutes);
    }

    public void DisplayState()
    {
        CurrentState.DisplayState();
    }


}
