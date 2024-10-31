using System;


public class Running : Activity
{

public double _distanceInKm;

public Running(DateTime date, int durationInMinutes, double ditanceInKm)
        : base (date, durationInMinutes)
        {
            _distanceInKm = ditanceInKm;

        }

        public override double GetDistance() => _distanceInKm;

        public override double GetSpeed() => (GetDistance()/ DurationInMinutes) * 60;
        public override double GetPace() => DurationInMinutes / GetDistance();
















}