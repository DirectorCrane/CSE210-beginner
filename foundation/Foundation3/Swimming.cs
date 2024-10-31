using System;





public class Swimming :Activity
{
private int _laps;
private const double LapLengthMeters = 50;
private const double MetersToKm = 1000;

public Swimming(DateTime date, int durationInMinutes, int laps)
    :base (date, durationInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * LapLengthMeters ) / MetersToKm;
    public override double GetSpeed() => (GetDistance() / DurationInMinutes ) * 60;
    public override double GetPace() => DurationInMinutes / GetDistance();


}