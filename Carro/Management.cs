using System;
using System.Threading;

namespace _Car;

public class Management
{
    // Atributos privados
    private string manufacturer; 
    private string model;
    private int year;
    private int velocity;
    private bool engineOn;
    // Métodos Construtores
    public Management(string manufacturer, string model, bool engineOn, int year, int velocity)
    {
        this.manufacturer=manufacturer;
        this.model=model;
        this.engineOn=engineOn;
        this.year=year;
        this.velocity=velocity;
    }
    public Management(string manufacturer, string model, int year)
    {
        this.manufacturer=manufacturer;
        this.model=model;
        this.year=year;
        this.velocity=0;
        this.engineOn=false;
    }
    // Métodos 
    public void details()
    {
        Console.WriteLine("-----Carro-----");
        Console.WriteLine("Fabricante: " + this.manufacturer);
        Console.WriteLine("Modelo: " + this.model);
        Console.WriteLine("Ano: " + this.year + "\n");
    }
    public string engineSituation()
    {
        Console.WriteLine("-----------------");
        if(this.engineOn == true)
            return this.model + " --> motor LIGADO \n";
        return this.model + " --> motor DESLIGADO \n";
    }
    public string startEngine()
    {
        Console.WriteLine("-----------------");
        if(this.engineOn == true)
            return "O motor do " + this.model + " já estava ligado \n";
        this.engineOn = true;
        Console.WriteLine("Ligando motor...");
        Thread.Sleep(2000);
        return "O motor do " + this.model + " foi ligado agora \n";    
    }
    // Gets e Sets
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
