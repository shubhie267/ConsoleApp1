using System;


enum levels
{
    high,
    medium,
    low
}


// interface
interface Animals
{
   public void makessound(); 
     
}


class pig : Animals
{
    
    public void makessound()
    {
        Console.WriteLine("pig makes weee weee sound");
    }
}

 class dog : Animals
{
    public void makessound()
    {
        Console.WriteLine("dog makes boww boww sound");
    }
}