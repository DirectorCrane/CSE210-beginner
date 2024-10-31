using System;




public abstract class Activity 
{
    private DateTime _date;
    private int _durationInMinutes;

    public Activity(DateTime date, int durationInMinutes )
    {
    _date = date;
    _durationInMinutes = durationInMinutes;
    }

    public DateTime Date => Date;
    public int DurationInMinutes => _durationInMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name}({_durationInMinutes} min) - " +
                $"Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }



}









