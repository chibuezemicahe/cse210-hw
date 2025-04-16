public class Swimming : Activity
{
    private int _laps;
    private const double METERS_PER_LAP = 50;
    private const double METERS_PER_MILE = 1609.34;

    public Swimming(DateTime date, int minutes, int laps) 
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * METERS_PER_LAP) / METERS_PER_MILE;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}