using System;

public class Adventurer
{
    public string name;
    public int experience = 0;


    public Adventurer()
    {
        Reset();
    }

    /*public Character()
    {
        name = "Not assigned";
    }*/

    public Adventurer(string name)
    {
        this.name = name;
    }

    public virtual void PrintStatsInfo()
    {
        Console.WriteLine("Hero: " + this.name + " - " + this.exp + " EXP");
    }


    private void Reset()
    {
        this.name = "Not assigned";
        this.experience = 0;
    }

}