using System;

public class bank
{
    int id;
    
    public bank(int i)
    {
        id = i;
        Console.WriteLine("ID: "+ id);
    }
    
    ~bank()
    {
        Console.WriteLine("Account ID: "+ id);
    }
    
    static void Main()
    {
        bank obj1 = new bank (12435);
    }
}
