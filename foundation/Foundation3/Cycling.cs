using System;

public class Cycling : Activity
{
    private double _speedKph;
    public Cycling (DateTime date, int durationInMinutes, double speedKph)
        : base(date, durationInMinutes)
        {
            _speedKph = speedKph;
        }

    public override double GetDistance() => (_speedKph * DurationInMinutes) / 60;
    public override double GetSpeed() => _speedKph;
    public override double GetPace() => 60 / _speedKph;
    











}