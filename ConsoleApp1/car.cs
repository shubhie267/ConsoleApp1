using System;

public class car : Vehicle
{
    public string color = "red";
    public int speed;
    public string model;
    public string price;

    private string name;

    public string Name

    { get; set; }



    public void fullthrottle()
    {
        Console.WriteLine("car is racing with speed of" + speed);
    }

    public car(int speed, string model, string price)
    {
        this.speed = speed;
        this.model = model;
        this.price = price;
    }
}

public class Vehicle
{
    public void honk()
    {
        Console.WriteLine("This vehicle honks very loud");
    }
}
