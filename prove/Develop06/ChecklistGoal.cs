using System;


public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _requiredTimes;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int requiredTimes = 5, int bonusPoints = 500)
        : base (name, description, points)
        
        {   
            _timesCompleted = 0 ;
          _requiredTimes = requiredTimes;
          _bonusPoints = bonusPoints;
            

        }

        public override void RecordEvent()
        {
            _timesCompleted++;
            if (_timesCompleted >= _requiredTimes)
            {
                
                _points += _bonusPoints;
            }
            

        }

        public override string GetStatus() => $"Completed{_timesCompleted}/{_requiredTimes} times";

// currentcompletions












}
























