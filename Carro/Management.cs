using System;
using System.Threading;

namespace _Car;

public class Management
{
    private string manufacturer; 
    private string model;
    private bool engineOn;
    private int year;
    private int velocity;

    public Management(string manufacturer, string model, bool engineOn, int year, int velocity)
    {
        this.manufacturer=manufacturer;
        this.model=model;
        this.engineOn=engineOn;
        this.year=year;
        this.velocity=velocity;
    }
    public string Manufacturer
    {
        get{return manufacturer;}
        set{manufacturer=value;}
    }
    public string Model
    {
        get{return model;}
        set{model=value;}
    }
    public bool EngineOn
    {
        get{return engineOn;}
        set{engineOn=value;}
    }
    public int Year
    {
        get{return year;}
        set{year=value;}
    }
    public int Velocity
    {
        get{return velocity;} 
        set{velocity=value;}
    }
}
