using System;



public abstract class Goal
{
    private string _name;
    private string _description;
    protected int _points;
    

    public Goal(string name, string description, int points)
    {

        _name = name;
        _description = description;
        _points = points;
        


    }

    public string GetName() => _name;
    public string GetDescription () => _description;
    public int GetPoints() => _points;
    public virtual string GetStatus() => "[ ]";
    public abstract void RecordEvent();

    


}